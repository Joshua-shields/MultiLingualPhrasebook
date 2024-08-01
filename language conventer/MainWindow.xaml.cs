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
                    
                },
                new Phrase
        {
            English = "What's your name?",
            Translations = new Dictionary<string, string>
            {
                {"Mandarin Chinese", "你叫什么名字？"}, {"Spanish", "¿Cómo te llamas?"}, {"Hindi", "आपका नाम क्या है?"},
                {"Arabic", "ما اسمك؟"}, {"Bengali", "আপনার নাম কি?"}, {"Portuguese", "Qual é o seu nome?"},
                {"Russian", "Как вас зовут?"}, {"Japanese", "お名前は何ですか？"}, {"French", "Comment vous appelez-vous?"},
                {"German", "Wie heißen Sie?"}, {"Urdu", "آپ کا نام کیا ہے؟"}, {"Korean", "이름이 뭐예요?"},
                {"Turkish", "Adınız ne?"}, {"Italian", "Come ti chiami?"}
            }
        },
        new Phrase
        {
            English = "Where is the bathroom?",
            Translations = new Dictionary<string, string>
            {
                {"Mandarin Chinese", "洗手间在哪里？"}, {"Spanish", "¿Dónde está el baño?"}, {"Hindi", "बाथरूम कहाँ है?"},
                {"Arabic", "أين الحمام؟"}, {"Bengali", "বাথরুম কোথায়?"}, {"Portuguese", "Onde fica o banheiro?"},
                {"Russian", "Где туалет?"}, {"Japanese", "お手洗いはどこですか？"}, {"French", "Où sont les toilettes?"},
                {"German", "Wo ist die Toilette?"}, {"Urdu", "باتھ روم کہاں ہے؟"}, {"Korean", "화장실이 어디에 있나요?"},
                {"Turkish", "Tuvalet nerede?"}, {"Italian", "Dov'è il bagno?"}
            }
        },
        new Phrase
        {
            English = "I don't understand",
            Translations = new Dictionary<string, string>
            {
                {"Mandarin Chinese", "我不明白"}, {"Spanish", "No entiendo"}, {"Hindi", "मैं नहीं समझता"},
                {"Arabic", "أنا لا أفهم"}, {"Bengali", "আমি বুঝতে পারছি না"}, {"Portuguese", "Eu não entendo"},
                {"Russian", "Я не понимаю"}, {"Japanese", "わかりません"}, {"French", "Je ne comprends pas"},
                {"German", "Ich verstehe nicht"}, {"Urdu", "مجھے سمجھ نہیں آتا"}, {"Korean", "이해가 안 됩니다"},
                {"Turkish", "Anlamıyorum"}, {"Italian", "Non capisco"}
            }
        },
        new Phrase
        {
            English = "Can you help me?",
            Translations = new Dictionary<string, string>
            {
                {"Mandarin Chinese", "你能帮助我吗？"}, {"Spanish", "¿Puedes ayudarme?"}, {"Hindi", "क्या आप मेरी मदद कर सकते हैं?"},
                {"Arabic", "هل يمكنك مساعدتي؟"}, {"Bengali", "আপনি কি আমাকে সাহায্য করতে পারেন?"}, {"Portuguese", "Pode me ajudar?"},
                {"Russian", "Вы можете мне помочь?"}, {"Japanese", "助けていただけますか？"}, {"French", "Pouvez-vous m'aider?"},
                {"German", "Können Sie mir helfen?"}, {"Urdu", "کیا آپ میری مدد کر سکتے ہیں؟"}, {"Korean", "도와주실 수 있나요?"},
                {"Turkish", "Bana yardım edebilir misiniz?"}, {"Italian", "Puoi aiutarmi?"}
            }
        },
        new Phrase
        {
            English = "How much does this cost?",
            Translations = new Dictionary<string, string>
            {
                {"Mandarin Chinese", "这个多少钱？"}, {"Spanish", "¿Cuánto cuesta esto?"}, {"Hindi", "इसकी कीमत क्या है?"},
                {"Arabic", "كم يكلف هذا؟"}, {"Bengali", "এটার দাম কত?"}, {"Portuguese", "Quanto custa isto?"},
                {"Russian", "Сколько это стоит?"}, {"Japanese", "これはいくらですか？"}, {"French", "Combien ça coûte?"},
                {"German", "Wie viel kostet das?"}, {"Urdu", "اس کی قیمت کیا ہے؟"}, {"Korean", "이것의 가격이 얼마인가요?"},
                {"Turkish", "Bunun fiyatı ne kadar?"}, {"Italian", "Quanto costa questo?"}
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