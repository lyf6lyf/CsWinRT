// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

#include "pch.h"
#include "iostream"

using namespace winrt;
using namespace Windows::Foundation;
using namespace std;

int main()
{
    init_apartment();

    AuthoringDemo::Example ex;
    auto parent = ex.GetParent();
    auto child = ex.GetChild();
}
