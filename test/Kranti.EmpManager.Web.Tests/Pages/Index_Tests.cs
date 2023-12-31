﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Kranti.EmpManager.Pages;

public class Index_Tests : EmpManagerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
