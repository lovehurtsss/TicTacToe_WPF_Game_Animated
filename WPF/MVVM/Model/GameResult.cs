using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.MVVM.Model
{
    public class GameResult
    {
        public WinInfo WinInfo { get; set; }
        public Player Winner { get; set; }
    }
}
