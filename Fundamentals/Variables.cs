using System;


/// <summary>
/// Demostrates the concept of DataTypes and Varaibles in C#
/// </summary>
public class Variables
{
    int _rollNo;
    string _name;
    string _stream;
    public Variables(int roll, string name, string stream)
    {
        //System.Int32
        this._rollNo = roll;

        //System.String
        this._name = name;
        this._stream = stream;
    }

    public override string ToString()
    {
        return "Student details:\nRoll No:" + this._rollNo + "\nName:" + this._name + "\nStream:" + this._stream;
    }


}
