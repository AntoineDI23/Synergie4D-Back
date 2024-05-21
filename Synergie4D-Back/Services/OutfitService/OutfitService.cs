using Synergie4D_Back.Enums;
using Synergie4D_Back.Models.Outfit;

namespace Synergie4D_Back.Services.OutfitService
{
    public class OutfitService : IOutfitService
    {
        private static readonly List<Outfit> outfitList =
        [
            new() {
                Id = 1,
                Description = "T-shirt / jean / basket",
                Style = Style.Relaxed,
                Weather = Weather.Hot
            },
        ];

        public IEnumerable<Outfit> GetAllOutfits()
        {
            return outfitList;
        }

        public Outfit GetOutfitById(int outfitId)
        {
            throw new NotImplementedException();
        }
    }
}