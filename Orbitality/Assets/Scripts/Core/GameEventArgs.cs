using System;

[Serializable]
public class GameEventArgs : EventArgs
{
    public string type;
    public string str;
    public int? intParam;
    public float? floatParam;
    public bool boolParam;
    public object objectParam;
    public Action okAction;
    public Action failAction;
    public Action cancelAction;

    public GameEventArgs(string type, Action okAction = null, Action failAction = null, Action cancelAction = null, params object[] parameters)
    {
        this.type = type;
        this.okAction = okAction;
        this.failAction = failAction;
        this.cancelAction = cancelAction;
        foreach (var param in parameters)
        {
            switch (param)
            {
                case int i:
                    intParam = i;
                    break;
                case float f:
                    floatParam = f;
                    break;
                case string str:
                    this.str = str;
                    break;
                case bool b:
                    boolParam = b;
                    break;
                case object o:
                    objectParam = o;
                    break;
            }
        }
    }

    public GameEventArgs(string type, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, int? intParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.intParam = intParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, float? floatParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }

    public GameEventArgs(string type, string str, int? intParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, float? floatParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, int? intParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.intParam = intParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, int? intParam, float? floatParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.intParam = intParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, int? intParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.intParam = intParam; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, float? floatParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.boolParam = boolParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, float? floatParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.objectParam = objectParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }

    public GameEventArgs(string type, string str, int? intParam, float? floatParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, int? intParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, int? intParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, float? floatParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.boolParam = boolParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, float? floatParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.objectParam = objectParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, bool boolParam, int? intParam, float? floatParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.boolParam = boolParam; this.intParam = intParam; this.floatParam = floatParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, bool boolParam, int? intParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.boolParam = boolParam; this.intParam = intParam; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }

    public GameEventArgs(string type, string str, int? intParam, float? floatParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.floatParam = floatParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, int? intParam, float? floatParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.floatParam = floatParam; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, int? intParam, object objectParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.objectParam = objectParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, string str, object objectParam, float? floatParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.objectParam = objectParam; this.floatParam = floatParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
    public GameEventArgs(string type, object objectParam, int? intParam, float? floatParam, bool boolParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.objectParam = objectParam; this.intParam = intParam; this.floatParam = floatParam; this.boolParam = boolParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }

    public GameEventArgs(string type, string str, int? intParam, float? floatParam, bool boolParam, object objectParam, Action okAction = null, Action cancelAction = null, Action failAction = null) { this.type = type; this.str = str; this.intParam = intParam; this.floatParam = floatParam; this.boolParam = boolParam; this.objectParam = objectParam; this.okAction = okAction; this.cancelAction = cancelAction; this.failAction = failAction; }
}