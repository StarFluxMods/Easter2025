using System.Collections.Generic;
using KitchenData;

namespace Easter2025.Utilies
{
    public static class CenteralLang
    {
        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> HotCrossBunsProvider => new()
            {
                (Locale.English, new ApplianceInfo { Name = "Hot Cross Buns", Description = "Provides Hot Cross Buns" })
            };
        }

        public static class Recipes
        {
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