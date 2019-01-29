using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;


namespace WebApplication3
{
    public class Presenter1
    {
        IView _pView;
        IModel _pModel;

        public Presenter1(IView PView, IModel PModel)
        {
            _pView = PView;
            _pModel = PModel;
        }
        public void BindModalView()
        {
            List<String> ls; 
            int number;
            if (int.TryParse(_pView.TextforEvenNumbers, out number))
            {
                ls = _pModel.setInfo(number,2);
                _pView.TextBoxNumberEven = "Even Numbers till " + _pView.TextforEvenNumbers + ": " + ls[0];
            }
            else
            {
                _pView.TextBoxNumberEven = "Please enter an integer.";
            }
        }

        public void BindModalViewForNoDivBy7()
        {
            List<String> ls;
            int number;
            if (int.TryParse(_pView.TextNumberfor7Div, out number))
            {
                ls = _pModel.setInfo(number, 7);
                _pView.TextNumbersDivBy7 = "Numbers divisible by 7 till " + _pView.TextNumberfor7Div + ": " + ls[0];
            }
            else
            {
                _pView.TextBoxNumberEven = "Please enter an integer.";
            }
        }
    }
}