using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.Mes
{
    public enum MESTYPE : int
    {
        MES = 0,
        DLG
    }

    public enum MESFIELD : int
    {
        COMMENT = -1,
        INDEX = 0,
        ITEM_TEXT = 1,
        ITEM_G = 2,
        ITEM_I = 3,
        ITEM_TEST = 4,
        ITEM_R = 5,
        ITEM_RESULT = 6
    }

    public enum Gender : int
    {
        ALL = -1,
        FEMALE = 0,
        MALE = 1
    }
}
