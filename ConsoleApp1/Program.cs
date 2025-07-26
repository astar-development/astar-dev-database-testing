// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using AStar.Dev.Infrastructure.FilesDb.Data;
using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;

var              context           = new FilesContext();

var files = await File.ReadAllTextAsync("../../../files.json");
var fileList = files.FromJson<List<FileDetail>>(JsonSerializerOptions.Web);
context.FileDetails.AddRange(fileList);
await context.SaveChangesAsync();
Console.WriteLine("Hello, World!");
