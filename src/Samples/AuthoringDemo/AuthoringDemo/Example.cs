// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace AuthoringDemo
{
    public interface IParent {}

    public interface  IChild : IParent {}

    internal partial record Parent : IParent {}

    internal partial record Child : Parent, IChild {}

    public sealed class Example
    {
        public static IChild GetChild() { return new Child(); }

        public static IParent GetParent() { return new Parent(); }
    }
}
