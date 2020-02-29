using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Recademy.Desktop.BaseMvvmElements;
using Recademy.Desktop.ViewElementModel;

namespace Recademy.Desktop.ViewModels
{
    public class UserProfileViewModel : BaseNotificationClass
    {
        //TODO: add images
        //TODO: add achievement
        //TODO: add activity list
        public string Login { get; set; }
        public string Username { get; set; }
        public int PointCount { get; set; }

        public ObservableCollection<SkillListItemModel> SkillList { get; set; }

        public UserProfileViewModel()
        {
            //TODO: remove, debug info
            Login = "inredikawb";
            Username = "Fredi Kats";
            PointCount = 452;

            SkillList = new ObservableCollection<SkillListItemModel>()
            {
                new SkillListItemModel()
                {
                    SkillName = "F#",
                    Point = 32,
                    CityRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    },
                    CountryRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    },
                    WorldWideRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    }
                },

                new SkillListItemModel()
                {
                    SkillName = "C#",
                    Point = 32,
                    CityRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    },
                    CountryRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    },
                    WorldWideRate = new RateListItemModel()
                    {
                        RegionName = "lorem ipsum",
                        UserPlace = 32,
                        UsersCount = 32,
                        Percent = 32
                    }
                }
            };
        }
    }
}