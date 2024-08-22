namespace Evaluation.StringVisualizers;

public  class StringVisualizersTest
{
    private String str;
    private String html;
    private String json;
    private String yaml;
    private String xml;
    private String jwt;
    private String urlStr;
    private String strFromFile;
    private String htmlFromFile;
    private String htmlFromFile2;
    private String jsonFromFile;
    private String jsonCompactFromFile;
    private String yamlFromFile;
    private String xmlFromFile;
    private String xmlCompactFromFile;
    private String jwtFromFile;
    private String urlStrFromFile;

    public StringVisualizersTest()
    {
        html =
    $"<html><head><title>Your Title Here</title></head><body bgcolor=\"000000\"><hr/><a href=\"http://somegreatsite.com\">Link Name</a> is a link to another site<h1>This is a Header</h1><h2>This is a Medium Header</h2>Send me mail at <a href=\"mailto:support@yourcompany.com\">support@yourcompany.com</a>.<p>This is a new paragraph!</p><p><b>This is a new paragraph!</b><br/><b><i>This is a new sentence without a paragraph break, in bold italics.</i></b></p><hr/></body></html>";
        json = 
    "{\"browsers\":{\"fire=fox\":{\"name\":\"Firefox\",\"pref_url\":\"about:config\",\"releases\":{\"1\":{\"release_date\":\"2004-11-09\",\"null_prop\":null,\"status\":\"retired\",\"engine\":\"Gecko\",\"engine_version\":\"1.7\"}}}}}";
        yaml =
    $"company: spacelift\ndomain:\n - devops\n - devsecops\ntutorial:\n  - yaml:\n      name: \"YAML Ain't Markup Language\"\n      type: awesome\n      born: 2001\n  - json:\n      name: JavaScript Object Notation\n      type: great\n      born: 2001\nauthor: omkarbirade\npublished: true";
        xml = 
    $"<catalog><book id=\"bk101\"><author>Gamba=rdella, Matthew</author><title>XML Developer's Guide</title><genre>Computer</genre><price>44.95</price><publish_date>2000-10-01</publish_date><description>An in-depth look at creating applications with XML.</description></book><book id=\"bk102\"><author>Ralls, Kim</author><title>Midnight Rain</title><genre>Fantasy</genre><price>5.95</price><publish_date>2000-12-16</publish_date><description>A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.</description></book><book id=\"bk103\"><author>Corets, Eva</author><title>Maeve Ascendant</title><genre>Fantasy</genre><price>5.95</price><publish_date>2000-11-17</publish_date><description>After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society.</description></book><book id=\"bk104\"><author>Corets, Eva</author><title>Oberon's Legacy</title><genre>Fantasy</genre><price>5.95</price><publish_date>2001-03-10</publish_date><description>In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant.</description></book><book id=\"bk105\"><author>Corets, Eva</author><title>The Sundered Grail</title><genre>Fantasy</genre><price>5.95</price><publish_date>2001-09-10</publish_date><description>The two daughters of Maeve, half-sisters, battle one another for control of England. Sequel to Oberon's Legacy.</description></book><book id=\"bk106\"><author>Randall, Cynthia</author><title>Lover Birds</title><genre>Romance</genre><price>4.95</price><publish_date>2000-09-02</publish_date><description>When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled.</description></book><book id=\"bk107\"><author>Thurman, Paula</author><title>Splish Splash</title><genre>Romance</genre><price>4.95</price><publish_date>2000-11-02</publish_date><description>A deep sea diver finds true love twenty thousand leagues beneath the sea.</description></book><book id=\"bk108\"><author>Knorr, Stefan</author><title>Creepy Crawlies</title><genre>Horror</genre><price>4.95</price><publish_date>2000-12-06</publish_date><description>An anthology of horror stories about roaches,centipedes, scorpions  and other insects.</description></book><book id=\"bk109\"><author>Kress, Peter</author><title>Paradox Lost</title><genre>Science Fiction</genre><price>6.95</price><publish_date>2000-11-02</publish_date><description>After an inadvertant trip through a HeisenbergUncertainty Device, James Salway discovers the problems of being quantum.</description></book><book id=\"bk110\"><author>O'Brien, Tim</author><title>Microsoft .NET: The Programming Bible</title><genre>Computer</genre><price>36.95</price><publish_date>2000-12-09</publish_date><description>Microsoft's .NET initiative is explored in detail in this deep programmer's reference.</description></book><book id=\"bk111\"><author>O'Brien, Tim</author><title>MSXML3: A Comprehensive Guide</title><genre>Computer</genre><price>36.95</price><publish_date>2000-12-01</publish_date><description>The Microsoft MSXML3 parser is covered in detail, with attention to XML DOM interfaces, XSLT processing, SAX and more.</description></book><book id=\"bk112\"><author>Galos, Mike</author><title>Visual Studio 7: A Comprehensive Guide</title><genre>Computer</genre><price>49.95</price><publish_date>2001-04-16</publish_date><description>Microsoft Visual Studio 7 is explored in depth,looking at how Visual Basic, Visual C++, C#, and ASP+ are integrated into a comprehensive development environment.</description></book></catalog>";
        jwt =
    $"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
        urlStr = 
    $"This+is+a+short+URL+encoded+string.%0D%0AAnd+this+one+is+gonna+be+1000005000000+times+longer%21%21%21";

        htmlFromFile = 
    System.IO.File.ReadAllText(@"../../../../Evaluation/StringVisualizers/sources/index.html");
        htmlFromFile2 = 
    System.IO.File.ReadAllLines(@"../../../../Evaluation/StringVisualizers/sources/index.html").ToString();
        jsonFromFile = 
    System.IO.File.ReadAllText(@"../../../../Evaluation/StringVisualizers/sources/example.json");
        jsonCompactFromFile = 
    System.IO.File.ReadAllText(@"../../../../Evaluation/StringVisualizers/sources/exampleCompact.json");
        xmlFromFile = 
    System.IO.File.ReadAllText(@"../../../../Evaluation/StringVisualizers/sources/example.xml");
        xmlCompactFromFile = 
    System.IO.File.ReadAllText(@"../../../../Evaluation/StringVisualizers/sources/exampleCompact.xml");
    }
}