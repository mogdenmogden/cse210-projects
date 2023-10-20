public class Reference 
{
    private string _ref, _bk, _ch, _vs1, _vsN;
 
    public Reference(string bk, string ch, string begvs, string endvs)
    {
        _bk = bk;
        _ch = ch;
        _vs1 = begvs;
        _vsN = endvs;
        _ref = _bk+" "+_ch+":"+_vs1+"-"+_vsN;
        
    }
    public Reference(string bk, string ch, string begvs)
    {
        _bk = bk;
        _ch = ch;
        _vs1 = begvs;
        _ref = _bk+" "+_ch+":"+_vs1;
    }

    public string GetRf()
    {
        return _ref;
    }





    /*public (string address, string verse) GetVerse(string lead, string lag)
    {
        (string address, string verse) _theScripture = (lead, lag);
        return _theScripture;
    }
    
    public  void GetWkVs()
    {
        string _workingVerse = _fullRef.Split("|")[1];
    } 
    
    public  void GetRf()
    {
        string _ref = _fullRef.Split("|")[0];
    }
    
    */
}