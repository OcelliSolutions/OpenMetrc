﻿namespace OpenMetrc.V2.Tests.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class TestPriorityAttribute : Attribute
{
    public TestPriorityAttribute(int priority)
    {
        Priority = priority;
    }

    public int Priority { get; private set; }
}