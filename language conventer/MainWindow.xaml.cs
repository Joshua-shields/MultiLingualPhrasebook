using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace language_conventer
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<string> Languages { get; set; }
        public List<Phrase> Phrases { get; set; }

        private string _selectedLanguage;
        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                _selectedLanguage = value;
                OnPropertyChanged(nameof(SelectedLanguage));
            }
        }

        private Phrase _selectedPhrase;
        public Phrase SelectedPhrase
        {
            get => _selectedPhrase;
            set
            {
                _selectedPhrase = value;
                OnPropertyChanged(nameof(SelectedPhrase));
            }
        }

        private string _translatedText;
        public string TranslatedText
        {
            get => _translatedText;
            set
            {
                _translatedText = value;
                OnPropertyChanged(nameof(TranslatedText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            DataContext = this;
        }

        private void InitializeData()
        {
            Languages = new List<string>
            {
                "Mandarin Chinese", "Spanish", "Hindi", "Arabic", "Bengali",
                "Portuguese", "Russian", "Japanese", "French", "German",
                "Urdu", "Korean", "Turkish", "Italian"
            };

            Phrases = new List<Phrase>
            {
                new Phrase
                {
                    English = "Hello",
                    Translations = new Dictionary<string, string>
                    {
                        {"Mandarin Chinese", "你好"}, {"Spanish", "Hola"}, {"Hindi", "नमस्ते"},
                        {"Arabic", "مرحبا"}, {"Bengali", "হ্যালো"}, {"Portuguese", "Olá"},
                        {"Russian", "Здравствуйте"}, {"Japanese", "こんにちは"}, {"French", "Bonjour"},
                        {"German", "Hallo"}, {"Urdu", "ہیلو"}, {"Korean", "안녕하세요"},
                        {"Turkish", "Merhaba"}, {"Italian", "Ciao"}
                    }
                },
                new Phrase
                {
                    English = "Goodbye",
                    Translations = new Dictionary<string, string>
                    {
                        {"Mandarin Chinese", "再见"}, {"Spanish", "Adiós"}, {"Hindi", "अलविदा"},
                        {"Arabic", "وداعا"}, {"Bengali", "বিদায়"}, {"Portuguese", "Adeus"},
                        {"Russian", "До свидания"}, {"Japanese", "さようなら"}, {"French", "Au revoir"},
                        {"German", "Auf Wiedersehen"}, {"Urdu", "خدا حافظ"}, {"Korean", "안녕히 가세요"},
                        {"Turkish", "Güle güle"}, {"Italian", "Arrivederci"}
                    }
                },
                new Phrase
                {
                    English = "Thank you",
                    Translations = new Dictionary<string, string>
                    {
                        {"Mandarin Chinese", "谢谢"}, {"Spanish", "Gracias"}, {"Hindi", "धन्यवाद"},
                        {"Arabic", "شكرا"}, {"Bengali", "ধন্যবাদ"}, {"Portuguese", "Obrigado"},
                        {"Russian", "Спасибо"}, {"Japanese", "ありがとう"}, {"French", "Merci"},
                        {"German", "Danke"}, {"Urdu", "شکریہ"}, {"Korean", "감사합니다"},
                        {"Turkish", "Teşekkür ederim"}, {"Italian", "Grazie"}
                    }
                },
                new Phrase
                {
                    English = "How is it going",
                    Translations = new Dictionary<string, string>
                    {
                        {"Mandarin Chinese", "最近怎么样？"},{"Spanish", "¿Cómo va todo?"},{"Hindi", "कैसा चल रहा है?"},
                        {"Arabic", "كيف حالك؟"},{"Bengali", "কেমন চলছে?"},{"Portuguese", "Como estão as coisas?"},
                        {"Russian", "Как дела?"},{"Japanese", "調子はどうですか？"},{"French", "Comment ça va ?"},
                        {"German", "Wie geht's?"},{"Urdu", "کیسے ہے؟"},{"Korean", "어떻게 지내세요?"},{"Turkish", "Nasılsın?"},
                        {"Italian", "Come va?"}
                    }
                },
                new Phrase
                {
                    English = "Good morning",
                    Translations = new Dictionary<string, string>
                    {
                        {"Mandarin Chinese", "早上好"},{"Spanish", "Buenos días"},{"Hindi", "सुप्रभात"},
                        {"Arabic", "صباح الخير"},{"Bengali", "সুপ্রভাত"},{"Portuguese", "Bom dia"},
                        {"Russian", "Доброе утро"}, {"Japanese", "おはようございます"},{"French", "Bonjour"},
                        {"German", "Guten Morgen"},{"Urdu", "صبح بخیر"},{"Korean", "좋은 아침"},{"Turkish", "Günaydın"},
                        {"Italian", "Buongiorno"}
                    }

                }


            };
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedLanguage != null && SelectedPhrase != null)
            {
                TranslatedText = SelectedPhrase.Translations[SelectedLanguage];
            }
            else
            {
                TranslatedText = "Please select a language and a phrase.";
            }
        }

    }
}