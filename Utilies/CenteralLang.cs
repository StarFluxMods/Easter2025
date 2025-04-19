using System.Collections.Generic;
using KitchenData;

namespace Easter2025.Utilies
{
    public static class CenteralLang
    {
        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> HotCrossBunsProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Hot Cross Buns", Description = "Provides Hot Cross Buns"}),
                (Locale.English, new ApplianceInfo{Name = "Hot Cross Buns", Description = "Provides Hot Cross Buns"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Petits pains à la croix chaude", Description = "Fournit des brioches à la croix chaude"}),
                (Locale.German, new ApplianceInfo{Name = "Heiße Kreuzbrötchen", Description = "Bietet Hot Cross Buns"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Bollos calientes", Description = "Proporciona bollos calientes"}),
                (Locale.Polish, new ApplianceInfo{Name = "Hot Cross Buns", Description = "Zapewnia Hot Cross Buns"}),
                (Locale.Russian, new ApplianceInfo{Name = "Булочки с горячим крестом", Description = "Предоставляет булочки с горячим крестом"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Pãezinhos quentes", Description = "Fornece Hot Cross Buns"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ホット・クロス・パン", Description = "ホット・クロス・バンズを提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "热十字包", Description = "提供热十字包"}),
                (Locale.Korean, new ApplianceInfo{Name = "핫 크로스 번", Description = "핫 크로스 번 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Sıcak Çörekler", Description = "Sıcak Çapraz Çörekler Sağlar"}),
            };
            
            public static List<(Locale, ApplianceInfo)> EggMouldProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Egg Mould", Description = "Provides Egg Mould"}),
                (Locale.English, new ApplianceInfo{Name = "Egg Mould", Description = "Provides Egg Mould"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Moule à oeufs", Description = "Fournit des moules à oeufs"}),
                (Locale.German, new ApplianceInfo{Name = "Egg Mould", Description = "Bietet Eierform"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Molde para huevos", Description = "Proporciona molde para huevos"}),
                (Locale.Polish, new ApplianceInfo{Name = "Forma do jajek", Description = "Zapewnia formę do jajek"}),
                (Locale.Russian, new ApplianceInfo{Name = "Форма для яиц", Description = "Предоставляет форму для яиц"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Molde de ovo", Description = "Fornece molde de ovo"}),
                (Locale.Japanese, new ApplianceInfo{Name = "卵型", Description = "卵型を提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "鸡蛋模具", Description = "提供鸡蛋模具"}),
                (Locale.Korean, new ApplianceInfo{Name = "달걀 곰팡이", Description = "달걀 몰드 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Yumurta Kalıbı", Description = "Yumurta Kalıbı Sağlar"}),
            };
            
            public static List<(Locale, ApplianceInfo)> DyeProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Dye", Description = "Provides Dye"}),
                (Locale.English, new ApplianceInfo{Name = "Dye", Description = "Provides Dye"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Teinture", Description = "Fournit de la teinture"}),
                (Locale.German, new ApplianceInfo{Name = "Färben", Description = "Bietet Farbstoff"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Tinte", Description = "Proporciona tinte"}),
                (Locale.Polish, new ApplianceInfo{Name = "Barwnik", Description = "Zapewnia barwnik"}),
                (Locale.Russian, new ApplianceInfo{Name = "Краситель", Description = "Обеспечивает краситель"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Corante", Description = "Fornece corante"}),
                (Locale.Japanese, new ApplianceInfo{Name = "染料", Description = "染料を提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "染色", Description = "提供染料"}),
                (Locale.Korean, new ApplianceInfo{Name = "염료", Description = "염료 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Boya", Description = "Boya Sağlar"}),
            };
            
            public static List<(Locale, ApplianceInfo)> WrapperProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Wrapper", Description = "Provides Wrapper"}),
                (Locale.English, new ApplianceInfo{Name = "Wrapper", Description = "Provides Wrapper"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Enveloppe", Description = "Fournit un wrapper"}),
                (Locale.German, new ApplianceInfo{Name = "Wrapper", Description = "Bietet Wrapper"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Envoltura", Description = "Proporciona envoltura"}),
                (Locale.Polish, new ApplianceInfo{Name = "Owijka", Description = "Zapewnia opakowanie"}),
                (Locale.Russian, new ApplianceInfo{Name = "Обертка", Description = "Предоставляет обертку"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Embalagem", Description = "Fornece Wrapper"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ラッパー", Description = "ラッパーを提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "包装", Description = "提供包装"}),
                (Locale.Korean, new ApplianceInfo{Name = "래퍼", Description = "래퍼 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Sarıcı", Description = "Sarıcı Sağlar"}),
            };
        }

        public static class Recipes
        {
            public static Dictionary<Locale, string> EasterBread => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add a Boiled Egg to Raw Dough, Cook, and Serve."},
                {Locale.English, "Add a Boiled Egg to Raw Dough, Cook, and Serve."},
                {Locale.BlankText, ""},
                {Locale.French, "Ajoutez un œuf cuit à la pâte crue, faites cuire et servez."},
                {Locale.German, "Ein gekochtes Ei in den rohen Teig geben, kochen und servieren."},
                {Locale.Spanish, "Añadir un huevo cocido a la masa cruda, cocer y servir."},
                {Locale.Polish, "Dodaj ugotowane jajko do surowego ciasta, ugotuj i podawaj."},
                {Locale.Russian, "Добавьте вареное яйцо в сырое тесто, приготовьте и подавайте."},
                {Locale.PortugueseBrazil, "Adicione um ovo cozido à massa crua, cozinhe e sirva."},
                {Locale.Japanese, "生地にゆで卵を加え、焼いて盛り付ける。"},
                {Locale.ChineseSimplified, "在生面团中加入一个煮熟的鸡蛋，煮熟后即可食用。"},
                {Locale.Korean, "생 반죽에 삶은 달걀을 넣고 조리하여 제공합니다."},
                {Locale.Turkish, "Çiğ Hamura Haşlanmış Yumurta Ekleyin, Pişirin ve Servis Edin."},
            };
            public static Dictionary<Locale, string> RecipeCremeFilling => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add Milk, Butter, and Sugar to a Pot, then Cook."},
                {Locale.English, "Add Milk, Butter, and Sugar to a Pot, then Cook."},
                {Locale.BlankText, ""},
                {Locale.French, "Ajouter le lait, le beurre et le sucre dans une casserole, puis faire cuire."},
                {Locale.German, "Milch, Butter und Zucker in einen Topf geben und zum Kochen bringen."},
                {Locale.Spanish, "Añadir la leche, la mantequilla y el azúcar a una olla y cocer."},
                {Locale.Polish, "Dodaj mleko, masło i cukier do garnka, a następnie zagotuj."},
                {Locale.Russian, "Добавьте в кастрюлю молоко, масло и сахар, затем варите."},
                {Locale.PortugueseBrazil, "Adicione o leite, a manteiga e o açúcar em uma panela e cozinhe."},
                {Locale.Japanese, "鍋に牛乳、バター、砂糖を加えて煮る。"},
                {Locale.ChineseSimplified, "在锅中加入牛奶、黄油和糖，然后煮沸。"},
                {Locale.Korean, "냄비에 우유, 버터, 설탕을 넣고 조리합니다."},
                {Locale.Turkish, "Bir Tencereye Süt, Tereyağı ve Şekeri Ekleyip Pişirin."},
            };
            public static Dictionary<Locale, string> CremeEgg => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add Melted Chocolate to Egg Mould, Remove 2 Halves and fill them with Crème Filling, combine them together, Wrap, and Serve."},
                {Locale.English, "Add Melted Chocolate to Egg Mould, Remove 2 Halves and fill them with Crème Filling, combine them together, Wrap, and Serve."},
                {Locale.BlankText, ""},
                {Locale.French, "Ajouter le chocolat fondu au moule à œufs, retirer deux moitiés et les remplir de fourrage à la crème, mélanger le tout, envelopper et servir."},
                {Locale.German, "Geschmolzene Schokolade in die Eierform geben, 2 Hälften herausnehmen und mit der Cremefüllung füllen, vermengen, einwickeln und servieren."},
                {Locale.Spanish, "Añada el chocolate fundido al molde de huevo, retire 2 mitades y rellénelas con el relleno de crema, combínelos, envuélvalos y sírvalos."},
                {Locale.Polish, "Dodać roztopioną czekoladę do formy na jajka, wyjąć 2 połówki i napełnić je kremowym nadzieniem, połączyć razem, zawinąć i podawać."},
                {Locale.Russian, "Добавьте растопленный шоколад в форму для яиц, удалите 2 половинки и наполните их кремовой начинкой, соедините вместе, заверните и подавайте."},
                {Locale.PortugueseBrazil, "Adicione o chocolate derretido à fôrma de ovo, remova duas metades e encha-as com o recheio de creme, misture tudo, embrulhe e sirva."},
                {Locale.Japanese, "溶かしたチョコレートを卵型に入れ、半分に切った2つの卵型を取り出して生クリームを詰める。"},
                {Locale.ChineseSimplified, "在蛋模中加入融化的巧克力，取出两半，填入奶油馅，混合在一起，包好，上桌。"},
                {Locale.Korean, "달걀 틀에 녹인 초콜릿을 넣고 반을 떼어낸 후 크림 필링을 채운 다음 서로 합쳐서 포장하고 제공합니다."},
                {Locale.Turkish, "Eritilmiş Çikolatayı Yumurta Kalıbına ekleyin, 2 Yarısını çıkarın ve Kremalı Dolgu ile doldurun, birleştirin, Sarın ve Servis Edin."},
            };
            public static Dictionary<Locale, string> HotCrossBuns => new Dictionary<Locale, string>
            {
                {Locale.Default, "Cut Hot Cross Bun, Cook, Add Butter, Serve!"},
                {Locale.English, "Cut Hot Cross Bun, Cook, Add Butter, Serve!"},
                {Locale.BlankText, ""},
                {Locale.French, "Couper la brioche, cuire, ajouter du beurre, servir !"},
                {Locale.German, "Hot Cross Brötchen schneiden, kochen, Butter dazugeben, servieren!"},
                {Locale.Spanish, "Cortar Hot Cross Bun, Cocinar, Añadir Mantequilla, ¡Servir!"},
                {Locale.Polish, "Pokrój bułkę, ugotuj, dodaj masło, podawaj!"},
                {Locale.Russian, "Нарежьте булочку, приготовьте, добавьте масло, подавайте!"},
                {Locale.PortugueseBrazil, "Cortar o pão de forma, cozinhar, adicionar manteiga e servir!"},
                {Locale.Japanese, "ホットクロスパンを切り、焼いて、バターを加え、盛り付ける！"},
                {Locale.ChineseSimplified, "切十字包，煮熟，加黄油，上桌！"},
                {Locale.Korean, "핫 크로스 번을 자르고, 요리하고, 버터를 넣고, 서빙하세요!"},
                {Locale.Turkish, "Hot Cross Çörek Kes, Pişir, Tereyağı Ekle, Servis Et!"},
            };
            
            public static Dictionary<Locale, string> DyedEggs => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add Water and Eggs to a Pot, Boil, Portion, Add Dye, Serve!"},
                {Locale.English, "Add Water and Eggs to a Pot, Boil, Portion, Add Dye, Serve!"},
                {Locale.BlankText, ""},
                {Locale.French, "Ajoutez de l'eau et des œufs dans une casserole, faites bouillir, répartissez, ajoutez le colorant et servez !"},
                {Locale.German, "Wasser und Eier in einen Topf geben, kochen, portionieren, Färbemittel hinzufügen, servieren!"},
                {Locale.Spanish, "Añadir agua y huevos a una olla, hervir, porcionar, añadir colorante, ¡servir!"},
                {Locale.Polish, "Dodaj wodę i jajka do garnka, zagotuj, porcjuj, dodaj barwnik, podawaj!"},
                {Locale.Russian, "Добавьте воду и яйца в кастрюлю, варите, порционируйте, добавьте краситель, подавайте!"},
                {Locale.PortugueseBrazil, "Adicione água e ovos em uma panela, ferva, distribua, adicione o corante e sirva!"},
                {Locale.Japanese, "鍋に水と卵を入れ、沸騰させ、取り分け、染料を加え、盛り付ける！"},
                {Locale.ChineseSimplified, "在锅中加入水和鸡蛋，煮沸，分装，加入染料，上桌！"},
                {Locale.Korean, "냄비에 물과 계란을 넣고 끓인 후, 나누어 담고, 염료를 넣고, 서빙하세요!"},
                {Locale.Turkish, "Bir Tencereye Su ve Yumurta Ekleyin, Kaynatın, Porsiyonlayın, Boya Ekleyin, Servis Edin!"},
            };
            
            public static Dictionary<Locale, string> DevilledEggs => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add Water and Eggs to a Pot, Boil, Portion, Slice. Remove Yolk, Mix with Mayo, add back to Egg Slice"},
                {Locale.English, "Add Water and Eggs to a Pot, Boil, Portion, Slice. Remove Yolk, Mix with Mayo, add back to Egg Slice"},
                {Locale.BlankText, ""},
                {Locale.French, "Ajouter de l'eau et des œufs dans une casserole, faire bouillir, diviser en portions, couper en tranches. Retirer le jaune d'œuf, le mélanger à la mayonnaise et le remettre dans la tranche d'œuf."},
                {Locale.German, "Wasser und Eier in einen Topf geben, kochen, portionieren, in Scheiben schneiden. Eigelb herausnehmen, mit Mayo mischen, zurück in die Ei-Scheibe geben"},
                {Locale.Spanish, "Añadir agua y huevos a una olla, hervir, porcionar, cortar en rodajas. Retire la yema, mézclela con la mayonesa y vuelva a añadirla a la rodaja de huevo."},
                {Locale.Polish, "Dodaj wodę i jajka do garnka, zagotuj, porcjuj, pokrój. Wyjąć żółtko, wymieszać z majonezem, dodać z powrotem do plastra jajka."},
                {Locale.Russian, "Добавьте воду и яйца в кастрюлю, сварите, разделите на порции, нарежьте. Удалите желток, смешайте с майонезом, добавьте обратно в яичную нарезку."},
                {Locale.PortugueseBrazil, "Acrescente água e ovos em uma panela, ferva, divida em porções e corte em fatias. Remova a gema, misture com maionese e adicione novamente à fatia de ovo"},
                {Locale.Japanese, "鍋に水と卵を入れ、ゆで、取り分け、スライスする。黄身を取り出し、マヨと混ぜ、スライス卵に戻す。"},
                {Locale.ChineseSimplified, "在锅中加入水和鸡蛋，煮沸，分装，切片。取出蛋黄，与蛋黄酱混合，加回鸡蛋片中"},
                {Locale.Korean, "냄비에 물과 달걀을 넣고 끓인 후 나누어 슬라이스합니다. 노른자를 제거하고 마요네즈와 섞은 후 달걀 슬라이스에 다시 추가합니다."},
                {Locale.Turkish, "Bir Tencereye Su ve Yumurta Ekleyin, Kaynatın, Porsiyonlayın, Dilimleyin. Sarısını Çıkarın, Mayonez ile Karıştırın, Yumurta Dilimine Geri Ekleyin"},
            };
            
            public static Dictionary<Locale, string> RecipeMayonnaise => new Dictionary<Locale, string>
            {
                {Locale.Default, "Crack an egg, and combine with oil."},
                {Locale.English, "Crack an egg, and combine with oil."},
                {Locale.BlankText, ""},
                {Locale.French, "Casser un œuf et le mélanger à l'huile."},
                {Locale.German, "Ein Ei aufschlagen und mit dem Öl vermengen."},
                {Locale.Spanish, "Cascar un huevo y mezclarlo con el aceite."},
                {Locale.Polish, "Rozbij jajko i połącz z olejem."},
                {Locale.Russian, "Разбейте яйцо и соедините с маслом."},
                {Locale.PortugueseBrazil, "Quebre um ovo e misture com o óleo."},
                {Locale.Japanese, "卵を割りほぐし、油と混ぜ合わせる。"},
                {Locale.ChineseSimplified, "打入一个鸡蛋，与油混合。"},
                {Locale.Korean, "달걀을 깨서 기름과 섞습니다."},
                {Locale.Turkish, "Bir yumurta kırın ve yağ ile karıştırın."},
            };
        }

        public static class Unlocks
        {
            
            public static List<(Locale, UnlockInfo)> EasterBread => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "EasterBread", Description = "AddsEasterBread Eggs as a Dessert", FlavourText = "Rise, shine, and sprinkle!"}),
    (Locale.English, new UnlockInfo{Name = "EasterBread", Description = "AddsEasterBread Eggs as a Dessert", FlavourText = "Rise, shine, and sprinkle!"}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Pain de Pâques", Description = "Ajoute les œufs au pain de Pâques comme dessert", FlavourText = "Levez-vous, brillez et saupoudrez !"}),
    (Locale.German, new UnlockInfo{Name = "Osterbrot", Description = "Fügt Ostereier als Dessert hinzu", FlavourText = "Raus aus den Federn und rein ins Vergnügen!"}),
    (Locale.Spanish, new UnlockInfo{Name = "Pan de Pascua", Description = "AñadeHuevos de Pascua como postre", FlavourText = "¡Levántate, brilla y salpica!"}),
    (Locale.Polish, new UnlockInfo{Name = "EasterBread", Description = "DodajeEasterBread Eggs jako deser", FlavourText = "Powstań, świeć i zraszaj!"}),
    (Locale.Russian, new UnlockInfo{Name = "Пасхальный хлеб", Description = "Добавляет пасхальные хлебные яйца в качестве десерта", FlavourText = "Поднимайтесь, сияйте и рассыпайтесь!"}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Pão de Páscoa", Description = "Adiciona Ovos de Pão de Páscoa como sobremesa", FlavourText = "Levante-se, brilhe e polvilhe!"}),
    (Locale.Japanese, new UnlockInfo{Name = "イースターブレッド", Description = "デザートとしてイースターブレッドエッグを追加", FlavourText = "立ち上がり、輝き、振りまく！"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "复活节面包", Description = "添加复活节面包蛋作为甜点", FlavourText = "冉冉升起，闪耀光芒，洒满大地！"}),
    (Locale.Korean, new UnlockInfo{Name = "부활절빵", Description = "디저트로 부활절빵 달걀 추가하기", FlavourText = "일어나, 빛나고, 뿌려라!"}),
    (Locale.Turkish, new UnlockInfo{Name = "EasterBread", Description = "PaskalyaEkmeği Yumurtalarını Tatlı Olarak Ekler", FlavourText = "Kalkın, parlayın ve serpin!"}),
};
            public static List<(Locale, UnlockInfo)> CremeEgg => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "Creme Filled Eggs", Description = "Adds Creme Filled Eggs as a Dessert", FlavourText = "Melt-in-your-mouth mischief."}),
    (Locale.English, new UnlockInfo{Name = "Creme Filled Eggs", Description = "Adds Creme Filled Eggs as a Dessert", FlavourText = "Melt-in-your-mouth mischief."}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Œufs fourrés à la crème", Description = "Ajoute des œufs fourrés à la crème comme dessert", FlavourText = "Une espièglerie qui fond dans la bouche."}),
    (Locale.German, new UnlockInfo{Name = "Gefüllte Creme-Eier", Description = "Fügt mit Creme gefüllte Eier als Dessert hinzu", FlavourText = "Unfug, der einem auf der Zunge zergeht."}),
    (Locale.Spanish, new UnlockInfo{Name = "Huevos rellenos de crema", Description = "Añade huevos rellenos de crema como postre", FlavourText = "Una travesura que se derrite en la boca."}),
    (Locale.Polish, new UnlockInfo{Name = "Jajka nadziewane kremem", Description = "Dodaje jajka nadziewane kremem jako deser", FlavourText = "Rozpływające się w ustach psoty."}),
    (Locale.Russian, new UnlockInfo{Name = "Яйца с кремовой начинкой", Description = "Добавляет яйца с кремовой начинкой в качестве десерта", FlavourText = "Тающее во рту озорство."}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Ovos recheados com creme", Description = "Adiciona ovos recheados com creme como sobremesa", FlavourText = "Travessuras que derretem em sua boca."}),
    (Locale.Japanese, new UnlockInfo{Name = "クレーム・エッグ", Description = "デザートとしてクリーム卵を加える", FlavourText = "とろけるようないたずら。"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "奶油馅鸡蛋", Description = "添加奶油馅鸡蛋作为甜点", FlavourText = "入口即化的恶作剧"}),
    (Locale.Korean, new UnlockInfo{Name = "크림 필드 에그", Description = "디저트로 크림 필드 에그를 추가합니다.", FlavourText = "입안에서 녹아내리는 장난."}),
    (Locale.Turkish, new UnlockInfo{Name = "Krema Dolgulu Yumurtalar", Description = "Krema Dolgulu Yumurtaları Tatlı Olarak Ekliyor", FlavourText = "Ağzınızda eriyen bir yaramazlık."}),
};
            public static List<(Locale, UnlockInfo)> RecipeCremeFilling => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Creme Filling", Description = "", FlavourText = ""}),
                (Locale.English, new UnlockInfo{Name = "Creme Filling", Description = "", FlavourText = ""}),
                (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Garniture à la crème", Description = "", FlavourText = ""}),
                (Locale.German, new UnlockInfo{Name = "Creme-Füllung", Description = "", FlavourText = ""}),
                (Locale.Spanish, new UnlockInfo{Name = "Relleno de crema", Description = "", FlavourText = ""}),
                (Locale.Polish, new UnlockInfo{Name = "Nadzienie kremowe", Description = "", FlavourText = ""}),
                (Locale.Russian, new UnlockInfo{Name = "Кремовая начинка", Description = "", FlavourText = ""}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Recheio de creme", Description = "", FlavourText = ""}),
                (Locale.Japanese, new UnlockInfo{Name = "クリーム・フィリング", Description = "", FlavourText = ""}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "奶油馅", Description = "", FlavourText = ""}),
                (Locale.Korean, new UnlockInfo{Name = "크림 필링", Description = "", FlavourText = ""}),
                (Locale.Turkish, new UnlockInfo{Name = "Krema Dolgusu", Description = "", FlavourText = ""}),
            };
            public static List<(Locale, UnlockInfo)> RecipeMayonnaise => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.English, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.German, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.Spanish, new UnlockInfo{Name = "Mayonesa", Description = "", FlavourText = ""}),
                (Locale.Polish, new UnlockInfo{Name = "Majonez", Description = "", FlavourText = ""}),
                (Locale.Russian, new UnlockInfo{Name = "Майонез", Description = "", FlavourText = ""}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Maionese", Description = "", FlavourText = ""}),
                (Locale.Japanese, new UnlockInfo{Name = "マヨネーズ", Description = "", FlavourText = ""}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "蛋黄酱", Description = "", FlavourText = ""}),
                (Locale.Korean, new UnlockInfo{Name = "마요네즈", Description = "", FlavourText = ""}),
                (Locale.Turkish, new UnlockInfo{Name = "Mayonez", Description = "", FlavourText = ""}),
            };
            public static List<(Locale, UnlockInfo)> DyedEggs => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "Dyed Eggs", Description = "Adds Dyed Eggs as a Main", FlavourText = "A colourful twist on your classic protein."}),
    (Locale.English, new UnlockInfo{Name = "Dyed Eggs", Description = "Adds Dyed Eggs as a Main", FlavourText = "A colourful twist on your classic protein."}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Œufs teints", Description = "L'ajout d'œufs teints en tant qu'élément principal", FlavourText = "Une version colorée de la protéine classique."}),
    (Locale.German, new UnlockInfo{Name = "Gefärbte Eier", Description = "Fügt gefärbte Eier als Hauptnahrungsmittel hinzu", FlavourText = "Eine farbenfrohe Abwandlung des klassischen Proteins."}),
    (Locale.Spanish, new UnlockInfo{Name = "Huevos teñidos", Description = "Añade huevos teñidos como principal", FlavourText = "Un toque de color en tu proteína clásica."}),
    (Locale.Polish, new UnlockInfo{Name = "Barwione jajka", Description = "Dodaje barwione jajka jako główny składnik", FlavourText = "Kolorowa wariacja na temat klasycznego białka."}),
    (Locale.Russian, new UnlockInfo{Name = "Крашеные яйца", Description = "Добавляет крашеные яйца в качестве основного блюда", FlavourText = "Разноцветный поворот к классическому протеину."}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Ovos tingidos", Description = "Adiciona ovos tingidos como principal", FlavourText = "Um toque colorido em sua proteína clássica."}),
    (Locale.Japanese, new UnlockInfo{Name = "染色された卵", Description = "染卵をメインに加える", FlavourText = "定番のプロテインをカラフルにアレンジ。"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "染色鸡蛋", Description = "添加染色鸡蛋作为主食", FlavourText = "经典蛋白质的多彩变化"}),
    (Locale.Korean, new UnlockInfo{Name = "염색 달걀", Description = "염색한 달걀을 메인으로 추가합니다.", FlavourText = "클래식한 단백질을 다채롭게 변형한 제품입니다."}),
    (Locale.Turkish, new UnlockInfo{Name = "Boyalı Yumurtalar", Description = "Boyalı Yumurtaları Ana Ürün Olarak Ekler", FlavourText = "Klasik proteininize renkli bir dokunuş."}),
};
            
            public static List<(Locale, UnlockInfo)> DevilledEggs => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "Devilled Eggs", Description = "Adds DevilledEggs as a Side", FlavourText = "Angelic on the outside, sinful in the middle."}),
    (Locale.English, new UnlockInfo{Name = "Devilled Eggs", Description = "Adds DevilledEggs as a Side", FlavourText = "Angelic on the outside, sinful in the middle."}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Œufs tournés", Description = "Ajoute les œufs de veau à l'accompagnement", FlavourText = "Angélique à l'extérieur, pécheur au milieu."}),
    (Locale.German, new UnlockInfo{Name = "Devilled Eggs", Description = "Fügt DevilledEggs als Beilage hinzu", FlavourText = "Nach außen hin engelhaft, in der Mitte sündig."}),
    (Locale.Spanish, new UnlockInfo{Name = "Huevos rellenos", Description = "Añade DevilledEggs como guarnición", FlavourText = "Angelical por fuera, pecadora por dentro."}),
    (Locale.Polish, new UnlockInfo{Name = "Jajka sadzone", Description = "Dodaje DevilledEggs jako dodatek", FlavourText = "Anielski na zewnątrz, grzeszny w środku."}),
    (Locale.Russian, new UnlockInfo{Name = "Яйца вкрутую", Description = "Добавляет яичницу-глазунью в качестве гарнира", FlavourText = "Ангельская снаружи, грешная в середине."}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Ovos cozidos", Description = "Adiciona ovos cozidos como acompanhamento", FlavourText = "Angelical por fora, pecaminoso no meio."}),
    (Locale.Japanese, new UnlockInfo{Name = "デビルド・エッグ", Description = "サイドメニューにデビルエッグを追加", FlavourText = "外見は天使のようだが、中身は罪深い。"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "煎蛋", Description = "添加煎蛋作为配菜", FlavourText = "外表天使，内心罪恶。"}),
    (Locale.Korean, new UnlockInfo{Name = "데빌드 에그", Description = "데빌드에그를 사이드 메뉴로 추가합니다.", FlavourText = "겉은 천사 같지만 속은 죄악입니다."}),
    (Locale.Turkish, new UnlockInfo{Name = "Dolgulu Yumurta", Description = "Garnitür olarak DevilledEggs ekler", FlavourText = "Dışı melek gibi, ortası günahkâr."}),
};
            
            public static List<(Locale, UnlockInfo)> HotCrossBuns => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "Hot Cross Buns", Description = "Adds Hot Cross Buns as a Starter", FlavourText = "Easter’s soft and sticky anthem."}),
    (Locale.English, new UnlockInfo{Name = "Hot Cross Buns", Description = "Adds Hot Cross Buns as a Starter", FlavourText = "Easter’s soft and sticky anthem."}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Petits pains à la croix chaude", Description = "Ajoute des petits pains au chocolat en guise d'amorce", FlavourText = "L'hymne doux et collant de Pâques."}),
    (Locale.German, new UnlockInfo{Name = "Heiße Kreuzbrötchen", Description = "Fügt Hot Cross Buns als Vorspeise hinzu", FlavourText = "Die sanfte und klebrige Hymne von Ostern."}),
    (Locale.Spanish, new UnlockInfo{Name = "Bollos calientes", Description = "Añade bollos calientes como entrante", FlavourText = "El himno suave y pegajoso de Pascua."}),
    (Locale.Polish, new UnlockInfo{Name = "Hot Cross Buns", Description = "Dodaje Hot Cross Buns jako przystawkę", FlavourText = "Miękki i lepki hymn wielkanocny."}),
    (Locale.Russian, new UnlockInfo{Name = "Булочки с горячим крестом", Description = "Добавляет булочки с горячим крестом в качестве стартера", FlavourText = "Мягкий и тягучий пасхальный гимн."}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Pãezinhos quentes", Description = "Adiciona Hot Cross Buns como entrada", FlavourText = "O hino suave e pegajoso da Páscoa."}),
    (Locale.Japanese, new UnlockInfo{Name = "ホット・クロス・パン", Description = "ホットクロスバンズを前菜に加える", FlavourText = "イースターのソフトで粘り気のあるアンセム。"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "热十字包", Description = "添加热十字包作为开胃菜", FlavourText = "复活节柔和而粘稠的颂歌。"}),
    (Locale.Korean, new UnlockInfo{Name = "핫 크로스 번", Description = "핫 크로스 번을 스타터로 추가합니다.", FlavourText = "부활절의 부드럽고 끈적끈적한 찬송가."}),
    (Locale.Turkish, new UnlockInfo{Name = "Sıcak Çörekler", Description = "Başlangıç Olarak Sıcak Çörekler Ekler", FlavourText = "Paskalya'nın yumuşak ve yapışkan marşı."}),
};
        }
    }
}