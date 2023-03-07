

# [order_buddy](https://github.com/johnedisc/order-buddy.git)

#### by [johnedisc](https://johnedisc.github.io)

#### an excercise in making a simple ASP.NET MVC website with TDD in MSTest

## technologies used

* C#
* ASP.NET 6
* MSTest
* neovim text editor
* github/git

## description

* this is an epicodus project in our 2nd week of using C# and .NET framework. it required making multiple classes and multiple controllers to route the content to different views with both attribute routing and conventional routing. 
* this site uses shared views to allow passing html snippets to different parts of the website and incorporates a stylesheet
* the basic funtionality allows the user to create orders associated with different client vendors. the vendor stores those items in a list and prints them to the screen with their various details.

## setup/installation requirements

* open a terminal on your machine
* clone down the [repository from github](https://github.com/johnedisc/order-buddy.git) inside the directory of your choosing
```bash
git clone https://github.com/johnedisc/order-buddy.git
```
* move into the directory with Program.cs
```bash
cd OrderBuddy.Solution/OrderBuddy/
```
* start application
```bash
dotnet run
```
* to run tests, navigate to the OrderBuddy.Tests directory and run tests
```bash
cd ../OrderBuddy.Tests/
dotnet test
```

## known Bugs

* there is not yet a way to remove items

## license

feel free to get in touch at [christopher(dot)johnedis(at)gmail(dot)com](christopher.johnedis@gmail.com)

MIT License

Copyright (c) [2023] [christopher johnedis]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
