// See https://aka.ms/new-console-template for more information
using Blogger_server.Entities;
using proxy.Facade;


var post = new Post() { };
var SpellChecker = new ComplexSpellCheckingFacade() { };
SpellChecker.Check(post);
