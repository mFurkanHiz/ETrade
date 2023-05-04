using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class FoodsModel : BaseCrud
    {
        public FoodsModel()
        {
            SelectedFood = new Foods();
        }
        public Foods SelectedFood { get; set; }
        public List<CategoriesDTO> Categories { get; set; }

    }
}
