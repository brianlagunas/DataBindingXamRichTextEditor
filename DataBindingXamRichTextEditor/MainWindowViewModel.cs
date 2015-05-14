using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingXamRichTextEditor
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _htmlText;

        public string HtmlText
        {
            get { return _htmlText; }
            set
            {
                _htmlText = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
