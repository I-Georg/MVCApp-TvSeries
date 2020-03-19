using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.ViewModel
{
    public class TvSeriesUserViewModel
    {
        public UserModel Users { get; set; }

        public List<TvModel> TvSeries { get; set; }
    }
}