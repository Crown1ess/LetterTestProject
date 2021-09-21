using Letters.Commands;
using Letters.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using Letters.Service;
using System.Threading.Tasks;
using System.Collections;

namespace Letters.ViewModels
{
    class LetterViewModel : BaseViewModel
    {
        #region fields
        const string filePath = @".\letters.json";
        #endregion

        #region properties
        private string letterContent;
        public string LetterContent
        {
            get => letterContent;
            set
            {
                letterContent = value;
                OnPropertyChanged(nameof(LetterContent));
            }
        }

        private DateTime startDate = DateTime.Now;
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if(value <= FinishDate)
                {
                    startDate = value;
                    OnPropertyChanged(nameof(StartDate));
                }else
                {
                    Message.Show("Начальная дата не может быть позднее конечной даты");
                }
                
            }
        }

        private DateTime finishDate = DateTime.Now;
        public DateTime FinishDate
        {
            get => finishDate;
            set
            {
                if(value >= StartDate)
                {
                    finishDate = value;
                    OnPropertyChanged(nameof(FinishDate));
                }else
                {
                    Message.Show("Конечная дата не может быть раньше начальной даты");
                }
                
            }
        }
        //public ObservableCollection<Letter> SendedLetters { get; private set; }
        private ObservableCollection<Letter> sendedLetters;
        public ObservableCollection<Letter> SendedLetters
        {
            get => sendedLetters;
            set
            {
                sendedLetters = value;
                OnPropertyChanged(nameof(SendedLetters));
            }
        }
        #endregion


        #region commands
        private readonly ICommand sendCommand;
        public ICommand SendCommand => sendCommand;

        private readonly ICommand useFilterCommand;
        public ICommand UseFilterCommand => useFilterCommand;

        #endregion


        #region constructor
        public LetterViewModel()
        {
            Task.Run(() => SendedLetters = GetLetters());

            sendCommand = new RelayCommand(p => SendLetter(), p => true);
            useFilterCommand = new RelayCommand(UseFilter, p => true);

        }
        #endregion

        #region methods
        private async void SendLetter()
        {
            if (LetterContent == null || LetterContent.Trim() == "")
            {
                Message.Show("Сообщение не должно быть пустым!");
                return;
            }

            SendedLetters.Add( new Letter
            {
                Username = Environment.UserName,
                LetterContent = this.LetterContent,
                LetterSendDate = DateTime.Now
            });

            string jsonLetter = "{" + $"'letters': {JsonConvert.SerializeObject(SendedLetters)}" + "}";
            byte[] jsonLetterBytes = Encoding.Default.GetBytes(jsonLetter);

            using(FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                await fileStream.WriteAsync(jsonLetterBytes);
            }

            LetterContent = string.Empty;
        }

        private ObservableCollection<Letter> GetLetters()
        {
            using (FileStream readStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(readStream))
                {
                    if (readStream.Length > 0)
                    {
                        string json = reader.ReadToEnd();
                        JObject jsonObject = JObject.Parse(json);
                        JArray jsonArray = (JArray)jsonObject["letters"];
                        return jsonArray.ToObject<ObservableCollection<Letter>>();
                    }
                }
            }
            return new ObservableCollection<Letter>();
        }

        private void UseFilter(object parameter)
        {
            //if ((bool)parameter == false)
            //{
            //    SendedLetters = GetLetters();
            //    return;
            //}

            ObservableCollection<Letter> intersectLetters = new ObservableCollection<Letter>();

            for (int i = 0; i < SendedLetters.Count; i++)
            {
                if (SendedLetters[i].LetterSendDate >= StartDate && SendedLetters[i].LetterSendDate <= FinishDate)
                {
                    intersectLetters.Add(SendedLetters[i]);
                }
            }

            if (intersectLetters.Count <= 0)
            {
                RemoveAllItems(SendedLetters);
                return;
            }

            RemoveAllItems(SendedLetters);

            SendedLetters = intersectLetters;
        }

        private void RemoveAllItems(IList list)
        {
            while(list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
        #endregion
    }
}
