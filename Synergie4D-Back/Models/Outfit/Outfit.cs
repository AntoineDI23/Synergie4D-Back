namespace Synergie4D_Back.Models.Outfit
{
    public class Outfit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Enum Style { get; set; }
        public Enum Weather { get; set; }
        public string Slug { get; set; }
    }
}