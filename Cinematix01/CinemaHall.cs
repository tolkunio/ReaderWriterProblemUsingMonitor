using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cinematix01
{
    public class CinemaHall
    {
        public SeatState[][] _seats;
        
        public CinemaHall(int rowsCount, int colsCount)
        {
            _seats = new SeatState[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                _seats[i] = new SeatState[colsCount];
                for (int k = 0; k < colsCount; k++)
                {
                    _seats[i][k] = SeatState.Free;
                }
            }
        }
    }
}
