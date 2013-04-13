using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfCodeFastAndMvpAsp
{
    public class Presenter
    {
        private readonly IModel _model;

        public Presenter()
        {
            
        }

        public Presenter(IModel model)
        {
            _model = model;
        }

        public void ShowData()
        {
            _model.PersonalInfos = new Model().PersonalInfos;
        }

        public void AddPInfo(IView view)
        {
            var pInfo = new PersonalInfo
                            {
                                Address = view.Address,
                                DateofBirth = view.DateofBirth,
                                IsAlive = view.IsAlive,
                                Name = view.Name,
                                PhoneNumbet = view.PhoneNumbet
                            };
            new Model().Add(pInfo);
        }
    }
}