using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DTG;

public class GameDataManager : ManagerBase
{
    Dictionary<DataFileDefine, Dictionary<DataFileTabDefine, Dictionary<long, Dictionary<uint, int>>>> m_dicDatas = new Dictionary<DataFileDefine, Dictionary<DataFileTabDefine, Dictionary<long, Dictionary<uint, int>>>>();
    // File Έν , File Tab, FileID, FileFieldRow

    protected override void DestroyManager()
    {

    }

    protected override void InitManager() 
    {

    }




}
