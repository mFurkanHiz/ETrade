using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class CategoriesModel
    {
        public CategoriesModel()
        {
            SelectedCat = new Categories(); // farklı işlemleri tekrar yapabilmek için newleme yapmamız gerekiyor
        }

        public Categories SelectedCat { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
    }
}
