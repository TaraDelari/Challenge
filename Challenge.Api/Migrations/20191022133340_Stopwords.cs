using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge.Api.Migrations
{
    public partial class Stopwords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stopwords",
                columns: table => new
                {
                    Word = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stopwords", x => x.Word);
                });

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "a");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "q");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "que");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "quickly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "quite");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "qv");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "r");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ran");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "rather");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "rd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "put");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "readily");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "recent");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "recently");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ref");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "refs");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "regarding");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "regardless");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "regards");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "related");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "relatively");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "really");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "research");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "provides");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "promptly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "pages");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "part");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "particular");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "particularly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "past");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "per");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "perhaps");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "placed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "please");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "proud");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "plus");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "possible");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "possibly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "potentially");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "pp");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "predominantly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "present");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "previously");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "primarily");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "probably");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "poorly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "respectively");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "resulted");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "resulting");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "show");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "showed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shown");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "showns");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shows");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "significant");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "significantly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "similar");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "similarly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "since");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "slightly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "somebody");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "somehow");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "someone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "somethan");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "something");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sometime");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sometimes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "somewhat");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "six");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shall");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "several");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "results");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "right");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "run");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "said");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "saw");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "say");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "saying");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "says");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sec");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "section");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "see");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seeing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seem");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seemed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seeming");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seems");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seen");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "self");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "selves");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sent");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seven");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "page");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "p");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "owing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "overall");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "made");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mainly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "make");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "makes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "many");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "may");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "maybe");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mean");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "means");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ltd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "meantime");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "merely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mg");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "might");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "million");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "miss");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ml");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "moreover");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mostly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mr");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "meanwhile");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "looks");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "looking");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "look");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "know");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "known");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "knows");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "l");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "largely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "last");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "lately");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "later");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "latter");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "latterly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "least");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "less");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "lest");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "let");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "lets");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "like");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "liked");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "likely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "line");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "little");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "'ll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mrs");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "somewhere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "much");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "must");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nos");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "noted");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nothing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nowhere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "obtain");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "obtained");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "obviously");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "often");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "oh");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "normally");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ok");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "old");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "omitted");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "one");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ones");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "onto");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ord");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "others");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "otherwise");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "outside");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "okay");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "noone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nonetheless");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "none");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "n");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "na");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "name");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "namely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nay");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "near");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nearly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "necessarily");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "necessary");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "need");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "needs");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "neither");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "never");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nevertheless");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "new");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "next");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nine");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ninety");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nobody");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "non");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mug");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "soon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sorry");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "specifically");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "within");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "without");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wont");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "words");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "world");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wouldnt");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "www");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "x");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "yes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wish");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "yet");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "youre");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "z");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "zero");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "a's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ain't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "allow");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "allows");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "apart");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "appear");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "youd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "willing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "widely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whose");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whatever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "what'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whats");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whence");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whenever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whereafter");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whereas");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whereby");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wherein");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wheres");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whereupon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wherever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whether");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whim");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whither");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whod");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whoever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whole");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "who'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whomever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whos");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "appreciate");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "werent");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "appropriate");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "best");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "inasmuch");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "indicate");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "indicated");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "indicates");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "inner");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "insofar");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "it'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "novel");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "presumably");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ignored");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "reasonably");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "secondly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sensible");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "serious");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "seriously");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "t's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "third");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thorough");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thoroughly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "three");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "second");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hopefully");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "help");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hello");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "better");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "c'mon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "c's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "cant");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "changes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "clearly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "concerning");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "consequently");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "consider");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "considering");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "corresponding");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "course");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "currently");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "definitely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "described");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "despite");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "entirely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "exactly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "example");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "going");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "greetings");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "associated");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "km");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "went");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thereafter");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thereby");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thered");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "therefore");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "therein");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "there'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thereof");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "therere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "theres");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thence");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thereto");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "there've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "theyd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "theyre");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "think");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thou");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "though");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thoughh");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thousand");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "throug");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thereupon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "that've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thats");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thanx");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "specified");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "specify");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "specifying");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "still");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "stop");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "strongly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sub");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "substantially");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "successfully");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sufficiently");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "suggest");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sup");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "sure");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "take");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "taken");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "taking");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "tell");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "tends");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "th");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thank");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thanks");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "throughout");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "welcome");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thru");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "til");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "useful");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "usefully");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "usefulness");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "uses");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "using");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "usually");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "v");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "value");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "various");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "used");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "'ve");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "viz");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "vol");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "vols");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "vs");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "w");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "want");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wants");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wasnt");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "way");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "via");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "use");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "us");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ups");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "tip");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "together");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "took");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "toward");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "towards");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "tried");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "tries");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "truly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "try");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "trying");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ts");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "twice");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "two");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "u");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "un");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "unfortunately");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "unless");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "unlike");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "unlikely");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "unto");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "upon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "thus");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "well");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "kg");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "keeps");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "some");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "such");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "t");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "than");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "that");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "that'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "the");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "their");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "theirs");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "so");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "them");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "then");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "there");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "these");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "they");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "this");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "those");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "through");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "to");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "too");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "themselves");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "under");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shouldn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "should've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "off");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "on");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "once");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "only");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "or");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "other");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "our");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ours");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ourselves");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shouldn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "out");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "own");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "re");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "s");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "same");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shan");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "shan't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "she");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "she's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "should");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "over");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "until");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "up");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ve");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "you'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "you're");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "you've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "your");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "yours");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "yourself");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "yourselves");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "could");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "he'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "you'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "he'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "here's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "how's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "i'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "i'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "i'm");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "i've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "let's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ought");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "she'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "he's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "you");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "y");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wouldn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "very");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "was");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wasn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wasn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "we");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "were");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "weren");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "weren't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "what");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "when");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "where");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "which");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "while");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "who");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "whom");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "why");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "will");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "with");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "won");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "won't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wouldn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "of");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "o");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "now");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "not");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "by");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "can");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "couldn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "couldn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "d");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "did");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "didn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "didn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "do");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "but");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "does");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "doesn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "doing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "don");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "don't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "down");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "during");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "each");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "few");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "for");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "doesn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "both");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "between");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "below");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "about");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "above");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "after");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "again");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "against");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ain");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "all");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "am");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "an");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "and");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "any");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "are");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "aren");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "aren't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "as");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "at");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "be");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "because");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "been");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "before");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "being");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "from");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "she'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "further");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hadn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "it's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "its");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "itself");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "just");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "m");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ma");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "me");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mightn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "it");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mightn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "most");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mustn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "mustn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "my");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "myself");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "needn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "needn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "no");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "nor");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "more");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "isn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "isn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "is");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hadn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "has");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hasn");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hasn't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "have");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "haven");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "haven't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "having");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "he");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "her");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "here");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hers");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "herself");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "him");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "himself");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "his");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "how");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "i");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "if");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "in");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "into");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "had");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "that's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "there's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "they'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ex");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "except");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "f");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "far");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ff");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "fifth");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "first");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "five");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "fix");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "everywhere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "followed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "follows");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "former");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "formerly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "forth");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "found");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "four");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "furthermore");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "g");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "gave");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "following");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "everything");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "everyone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "everybody");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "downwards");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "due");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "e");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "edu");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "effect");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "eg");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "eight");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "eighty");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "either");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "else");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "elsewhere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "end");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ending");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "enough");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "especially");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "et");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "etc");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "even");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ever");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "every");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "get");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "done");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "gets");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "give");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hundred");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "id");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ie");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "im");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "immediate");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "immediately");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "importance");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "important");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "inc");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "however");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "indeed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "information");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "instead");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "invention");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "inward");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "itd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "it'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "j");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "k");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "keep");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "index");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "howbeit");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "home");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hither");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "given");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "gives");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "giving");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "go");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "goes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "gone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "got");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "gotten");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "h");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "happens");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hardly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hed");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hence");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hereafter");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hereby");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "herein");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "heres");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hereupon");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hi");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "hid");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "getting");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "kept");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "different");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "couldnt");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "affects");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "afterwards");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ah");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "almost");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "alone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "along");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "already");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "also");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "although");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "affecting");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "always");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "amongst");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "announce");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "another");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anybody");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anyhow");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anymore");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anyone");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anything");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anyway");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "among");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "affected");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "adj");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "added");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "they'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "they're");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "they've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "we'd");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "we'll");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "we're");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "we've");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "what's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "when's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "where's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "who's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "why's");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "would");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "able");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "abst");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "accordance");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "according");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "accordingly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "across");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "act");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "actually");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anyways");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "date");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "anywhere");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "approximately");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "beyond");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "biol");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "brief");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "briefly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "c");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ca");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "came");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "cannot");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "can't");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "besides");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "cause");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "certain");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "certainly");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "co");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "com");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "come");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "comes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "contain");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "containing");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "contains");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "causes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "beside");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "believe");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "behind");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "arent");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "arise");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "around");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "aside");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "ask");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "asking");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "auth");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "available");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "away");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "awfully");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "b");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "back");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "became");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "become");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "becomes");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "becoming");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "beforehand");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "begin");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "beginning");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "beginnings");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "begins");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "apparently");

            migrationBuilder.InsertData(
                table: "stopwords",
                column: "Word",
                value: "wonder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stopwords");
        }
    }
}
