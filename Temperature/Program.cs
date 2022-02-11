// See https://aka.ms/new-console-template for more information
using Temperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Conversion c = new Conversion();

double t;
double result;

// Celsius_to_Fahrenheit
t = 0d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");



CreateHostBuilder(args).Build().Run();


static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
});
           

