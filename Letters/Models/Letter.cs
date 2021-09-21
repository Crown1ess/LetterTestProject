using System;

namespace Letters.Models
{
    class Letter
    {
        private string letterContent;
        public string LetterContent
        {
            get => letterContent;
            set => letterContent = value;
        }

        private string username;
        public string Username
        {
            get => username;
            set => username = value;
        }

        private DateTime letterSendDate;
        public DateTime LetterSendDate
        {
            get => letterSendDate;
            set => letterSendDate = value;
        }
    }
}
