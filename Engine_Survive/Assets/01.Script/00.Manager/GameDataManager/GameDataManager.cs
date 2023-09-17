using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DTG;

public class GameDataManager : ManagerBase
{
    Dictionary<DataFileDefine, Dictionary<DataFileTabDefine, Dictionary<long, Dictionary<uint, int>>>> m_dicDatas = new Dictionary<DataFileDefine, Dictionary<DataFileTabDefine, Dictionary<long, Dictionary<uint, int>>>>();

    protected override void DestroyManager()
    {
        throw new System.NotImplementedException();
    }



    protected override void InitManager()
    {
        throw new System.NotImplementedException();
    }

    // File Έν , File Tab, FileID, FileFieldRow
}
