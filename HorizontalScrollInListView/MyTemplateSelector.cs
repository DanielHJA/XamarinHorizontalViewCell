using System;
using HorizontalScrollInListView;
using Xamarin.Forms;

namespace HorizontalScrollInListView
{
    public class MyTemplateSelector : DataTemplateSelector
    {

        public DataTemplate AnimalTemplate { get; set; }
        public DataTemplate AnimalListTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            if (item is Animal)
            {
                return AnimalTemplate;
            }

            if (item is AnimalList)
            {
                return AnimalListTemplate;
            }

            return null;
        }

    }
}