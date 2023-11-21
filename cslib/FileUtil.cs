using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class FileUtil
{
    //해쉬테이블 객체에 있는 내용을 파일로 저장
    public void SaveToFile(Hashtable babo, String fn)
    {
        System.IO.FileStream fs = System.IO.File.Create(fn);
        BinaryFormatter younghee = new BinaryFormatter();
        younghee.Serialize(fs, babo);
        fs.Close();
    }
    //파일에 있는 내용을 해쉬테이블로 로드
    public Hashtable LoadFromFile(String filename)
    {
        //파일에 있는 내용을 읽어와서 해쉬테이블에 넣는 코드
        //LoadFromFile
        FileStream fs = File.Open(filename,
                FileMode.Open, FileAccess.Read);
        BinaryFormatter youngchoon = new BinaryFormatter();
        Hashtable tmp = (Hashtable)youngchoon.Deserialize(fs);
        fs.Close();
        return tmp;
    }
}

