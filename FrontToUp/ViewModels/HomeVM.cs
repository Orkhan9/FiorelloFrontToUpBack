using FrontToUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<SliderImage> SliderImages { get; set; }
        public SliderText SliderText { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Valentine Valentine { get; set; }
        public ExpertText ExpertText { get; set; }
        public IEnumerable<ExpertImage> ExpertImages { get; set; }
        public BlogText BlogText { get; set; }
        public IEnumerable<BlogImage> BlogImages { get; set; }
        public IEnumerable<Say> Says { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
        public Subscribe Subscribe { get; set; }
    }
}
