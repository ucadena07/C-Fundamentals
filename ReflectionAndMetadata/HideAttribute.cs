using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata;

[AttributeUsage(AttributeTargets.Field,AllowMultiple = false)]
internal class HideAttribute : Attribute
{
    DateTime Begin { get; }
    DateTime End { get; }
    bool useRangeDate = false;
    public HideAttribute(int yearBegin, int monthBegin,int dayBegin,int yearEnd, int monthEnd,int dayEnd )
    {
        Begin = new DateTime(yearBegin, monthBegin, dayBegin);
        End = new DateTime(yearEnd, monthEnd, dayEnd);
        useRangeDate= true;
    }
    public HideAttribute()
    {
            
    }
    public bool Hide()
    {
        if(useRangeDate)
        {
            return DateTime.Now >= Begin && DateTime.Now <= End;
        }
        return true;
    }
}
