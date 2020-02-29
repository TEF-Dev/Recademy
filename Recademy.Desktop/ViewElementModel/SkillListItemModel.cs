namespace Recademy.Desktop.ViewElementModel
{
    public class SkillListItemModel
    {
        public string SkillName { get; set; }
        public int Point { get; set; }

        public RateListItemModel CityRate { get; set; }
        public RateListItemModel CountryRate { get; set; }
        public RateListItemModel WorldWideRate { get; set; }
    }
}