using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Mes
{
    public enum MESTYPE
    {
        MES = 0,
        DLG
    }

    public enum DLGFIELD
    {
        COMMENT = -2,
        INDEX = -1,
        ITEM_TEXT = 0,
        ITEM_G = 1,
        ITEM_I = 2,
        ITEM_TEST = 3,
        ITEM_R = 4,
        ITEM_RESULT = 5
    }

    public enum Gender : int
    {
        ALL = -1,
        FEMALE = 0,
        MALE = 1
    }
}
