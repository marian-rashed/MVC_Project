using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Project.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PricePerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName", "Biography", "BirthDate", "Country", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Sandra Cisneros", "Sandra Cisneros is an American writer best known for her acclaimed first novel The House on Mango Street.", new DateTime(1954, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Sandra_Cisneros.jpg" },
                    { 2, "Gabriel García Márquez", "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo throughout Latin America. He is considered one of the most significant authors of the 20th century.", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombia", "/images/author/Gabriel_Garcia_Marquez.jpg" },
                    { 3, "Sarah J. Maas", "Sarah J. Maas is the #1 New York Times and internationally bestselling author of the Crescent City, A Court of Thorns and Roses, and the Throne of Glass series. Her books have sold more than twelve million copies and are published in thirty-seven languages. A New York native, Sarah lives in Philadelphia with her husband, son, and dog. To find out more, visit sarahjmaas.com or follow @therealsjmaas on Instagram.", new DateTime(1986, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Sarah_ J_Maas.jpeg" },
                    { 4, "Leigh Bardugo", "Leigh Bardugo is an American fantasy author. She is best known for her young adult Grishaverse novels, which include the Shadow and Bone trilogy and the Six of Crows and King of Scars duologies. She also received acclaim for her paranormal fantasy adult debut, Ninth House", new DateTime(1975, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Leigh_Bardugo.jpeg" },
                    { 5, "Cassandra Clare", "Judith Lewis, better known by her pen name Cassandra Clare, is an American author of young adult fiction, best known for her bestselling series The Mortal Instruments.", new DateTime(1975, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Cassandra_Clare.jpeg" },
                    { 6, "J.K. Rowling", "J.K. Rowling is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history.", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "/images/author/jk rowling.jpg" },
                    { 7, "Stephen King", "Stephen King is an American author of horror, supernatural fiction, suspense, crime, science-fiction, and fantasy novels. His books have sold more than 350 million copies, and many have been adapted into films, television series, miniseries, and comic books.", new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Stephen_king.jpg" },
                    { 8, "Haruki Murakami", "Haruki Murakami is a Japanese writer. His books and stories have been bestsellers in Japan and internationally, with his work being translated into 50 languages and selling millions of copies outside his native country.", new DateTime(1949, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "/images/author/Haruki_Murakami.jpeg" },
                    { 9, "Margaret Atwood", "Margaret Atwood is a Canadian poet, novelist, literary critic, essayist, inventor, teacher, and environmental activist. She has published over 17 books of poetry, 16 novels, 10 books of non-fiction, 8 collections of short fiction, 8 children's books, and 1 graphic novel.", new DateTime(1939, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "/images/author/Margaret_Atwood.jpg" },
                    { 10, "George R.R. Martin", "George R.R. Martin is an American novelist and short story writer, screenwriter, and television producer. He is best known for his series of epic fantasy novels, A Song of Ice and Fire, which was adapted into the HBO series Game of Thrones.", new DateTime(1948, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/George_R_R_Martin.jpg" },
                    { 11, "Toni Morrison", "Toni Morrison was an American novelist, essayist, editor, teacher, and professor emeritus at Princeton University. She won the Pulitzer Prize and the American Book Award in 1988 for Beloved.", new DateTime(1931, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Toni_Morrison.jpg" },
                    { 12, "Chimamanda Ngozi Adichie", "Chimamanda Ngozi Adichie is a Nigerian writer whose works range from novels to short stories to nonfiction. She was described in The Times Literary Supplement as 'the most prominent' of a 'procession of critically acclaimed young anglophone authors [which] is succeeding in attracting a new generation of readers to African literature'.", new DateTime(1977, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigeria", "/images/author/Chimamanda_Ngozi_Adichie.jpg" },
                    { 13, "Neil Gaiman", "Neil Gaiman is an English author of short fiction, novels, comic books, graphic novels, nonfiction, audio theatre, and films. His works include the comic book series The Sandman and novels Stardust, American Gods, Coraline, and The Graveyard Book.", new DateTime(1960, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "/images/author/Neil_Gaiman.jpg" },
                    { 14, "Virginia Woolf", "Virginia Woolf was an English writer, considered one of the most important modernist 20th-century authors and also a pioneer in the use of stream of consciousness as a narrative device. Woolf was a significant figure in London literary society and a member of the Bloomsbury Group.", new DateTime(1882, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "/images/author/Virginia _Wolf.jpeg" },
                    { 15, "Hermann Hesse", "Hermann Hesse was a German-Swiss poet, novelist, and painter. His best-known works include Steppenwolf, Siddhartha, and The Glass Bead Game, each of which explores an individual's search for authenticity, self-knowledge, and spirituality.", new DateTime(1877, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "/images/author/Hermman_Hesse.jpg" },
                    { 16, "Agatha Christie", "Agatha Christie was an English writer known for her sixty-six detective novels and fourteen short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple.", new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "/images/author/Agatha_Christie.jpg" },
                    { 17, "Octavia E. Butler", "Octavia E. Butler was an American science fiction writer. A multiple recipient of both the Hugo and Nebula awards, she became in 1995 the first science-fiction writer to receive a MacArthur Fellowship.", new DateTime(1947, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Octivia_Butler.jpeg" },
                    { 18, "Ernest Hemingway", "Ernest Hemingway was an American novelist, short-story writer, journalist, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations.", new DateTime(1899, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "/images/author/Ernest_Hemingway.jpg" },
                    { 19, "J.R.R. Tolkien", "J.R.R. Tolkien was an English writer, poet, philologist, and university professor. He was best known as the author of the classic high fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion.", new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", "/images/author/JRR Tolkin.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FullName", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown, USA", "john_doe@example.com", "John Doe", "password123", "123-456-7890", "john_doe" },
                    { 2, "456 Oak St, Anycity, USA", "jane_smith@example.com", "Jane Smith", "password456", "987-654-3210", "jane_smith" },
                    { 3, "789 Oak St, Anytown, USA", "mike_jackson@example.com", "Mike Jackson", "strongpwd456", "555-123-4567", "mike_jackson" },
                    { 4, "321 Pine St, Anytown, USA", "sarah_adams@example.com", "Sarah Adams", "mypassword789", "444-222-3333", "sarah_adams" },
                    { 5, "567 Maple St, Anytown, USA", "alex_miller@example.com", "Alex Miller", "alexpass123", "111-999-8888", "alex_miller" },
                    { 6, "246 Birch St, Anytown, USA", "emily_taylor@example.com", "Emily Taylor", "password987", "777-666-5555", "emily_taylor" },
                    { 7, "135 Cedar St, Anytown, USA", "ryan_carter@example.com", "Ryan Carter", "carterpass456", "999-777-6666", "ryan_carter" },
                    { 8, "753 Walnut St, Anytown, USA", "lisa_wilson@example.com", "Lisa Wilson", "secure1234", "222-333-4444", "lisa_wilson" },
                    { 9, "987 Birch St, Anytown, USA", "david_thompson@example.com", "David Thompson", "davidpass789", "888-555-2222", "david_thompson" },
                    { 10, "369 Oak St, Anytown, USA", "sophia_harris@example.com", "Sophia Harris", "harrissafe123", "777-888-9999", "sophia_harris" },
                    { 11, "456 Pine St, Othertown, Canada", "mark_johnson@example.com", "Mark Johnson", "markpass123", "111-222-3333", "mark_johnson" },
                    { 12, "789 Maple St, Anothertown, Australia", "emily_smith@example.com", "Emily Smith", "emilypass456", "444-555-6666", "emily_smith" },
                    { 13, "987 Elm St, Yetanothertown, United Kingdom", "alexander_brown@example.com", "Alexander Brown", "brownsecure123", "777-888-9999", "alexander_brown" },
                    { 14, "321 Cedar St, Differenttown, Germany", "olivia_davis@example.com", "Olivia Davis", "oliviapass789", "888-999-0000", "olivia_davis" },
                    { 15, "654 Oak St, Anotherdifferenttown, France", "william_taylor@example.com", "William Taylor", "williampass123", "222-333-4444", "william_taylor" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "ImageUrl", "Price", "QuantityAvailable", "Title" },
                values: new object[,]
                {
                    { 1, 1, "/images/book/the_house_on_mango_street.jpeg", 10.99m, 50, "The House on Mango Street" },
                    { 2, 1, "/images/book/caramelo.jpeg", 12.50m, 30, "Caramelo" },
                    { 3, 1, "/images/book/woman_hollering_creek.jpeg", 9.99m, 40, "Woman Hollering Creek and Other Stories" },
                    { 4, 2, "/images/book/one_hundred_years_of_solitude.jpeg", 12.50m, 30, "One Hundred Years of Solitude" },
                    { 5, 3, "/images/book/throne_of_glass.jpeg", 11.99m, 35, "Throne of Glass" },
                    { 6, 3, "/images/book/a_court_of_thorns_and_roses.jpeg", 14.99m, 25, "A Court of Thorns and Roses" },
                    { 7, 3, "/images/book/crescent_city.jpeg", 16.99m, 20, "Crescent City: House of Earth and Blood" },
                    { 8, 4, "/images/book/shadow_and_bone.jpeg", 13.99m, 30, "Shadow and Bone" },
                    { 9, 4, "/images/book/six_of_crows.jpeg", 15.99m, 25, "Six of Crows" },
                    { 10, 4, "/images/book/king_of_scars.jpeg", 14.50m, 28, "King of Scars" },
                    { 11, 5, "/images/book/city_of_bones.jpeg", 11.99m, 40, "City of Bones" },
                    { 12, 5, "/images/book/clockwork_angel.jpeg", 10.99m, 35, "Clockwork Angel" },
                    { 13, 5, "/images/book/lady_midnight.jpeg", 12.50m, 30, "Lady Midnight" },
                    { 14, 13, "/images/book/american_gods.jpeg", 15.99m, 20, "American Gods" },
                    { 15, 13, "/images/book/stardust.jpeg", 12.99m, 25, "Stardust" },
                    { 16, 14, "/images/book/to_the_lighthouse.jpeg", 9.99m, 15, "To the Lighthouse" },
                    { 17, 14, "/images/book/mrs_dalloway.jpeg", 10.99m, 18, "Mrs. Dalloway" },
                    { 18, 15, "/images/book/siddhartha.jpeg", 8.99m, 22, "Siddhartha" },
                    { 19, 15, "/images/book/steppenwolf.jpeg", 11.50m, 20, "Steppenwolf" },
                    { 20, 16, "/images/book/murder_on_the_orient_express.jpeg", 7.99m, 30, "Murder on the Orient Express" },
                    { 21, 16, "/images/book/and_then_there_were_none.jpeg", 6.99m, 28, "And Then There Were None" },
                    { 22, 17, "/images/book/kindred.jpeg", 13.99m, 20, "Kindred" },
                    { 23, 17, "/images/book/parable_of_the_sower.jpeg", 14.50m, 15, "Parable of the Sower" },
                    { 24, 18, "/images/book/the_old_man_and_the_sea.jpeg", 8.99m, 25, "The Old Man and the Sea" },
                    { 25, 18, "/images/book/a_farewell_to_arms.jpeg", 10.50m, 20, "A Farewell to Arms" },
                    { 26, 18, "/images/book/for_whom_the_bell_tolls.jpeg", 12.99m, 30, "For Whom the Bell Tolls" },
                    { 27, 19, "/images/book/the_hobbit.jpeg", 9.99m, 40, "The Hobbit" },
                    { 28, 19, "/images/book/the_fellowship_of_the_ring.jpeg", 11.50m, 35, "The Fellowship of the Ring" },
                    { 29, 19, "/images/book/the_silmarillion.jpeg", 14.50m, 30, "The Silmarillion" },
                    { 30, 6, "/images/book/harry_potter_and_the_philosophers_stone.jpeg", 12.99m, 25, "Harry Potter and the Philosopher's Stone" },
                    { 31, 6, "/images/book/harry_potter_and_the_chamber_of_secrets.jpeg", 13.99m, 20, "Harry Potter and the Chamber of Secrets" },
                    { 32, 6, "/images/book/harry_potter_and_the_prisoner_of_azkaban.jpeg", 14.99m, 30, "Harry Potter and the Prisoner of Azkaban" },
                    { 33, 6, "/images/book/harry_potter_and_the_goblet_of_fire.jpeg", 15.99m, 28, "Harry Potter and the Goblet of Fire" },
                    { 34, 7, "/images/book/the_shining.jpeg", 11.99m, 20, "The Shining" },
                    { 35, 7, "/images/book/it.jpeg", 14.50m, 22, "It" },
                    { 36, 8, "/images/book/norwegian_wood.jpeg", 12.99m, 18, "Norwegian Wood" },
                    { 37, 8, "/images/book/kafka_on_the_shore.jpeg", 13.50m, 20, "Kafka on the Shore" },
                    { 38, 9, "/images/book/the_testaments.jpeg", 15.99m, 22, "The Testaments" },
                    { 39, 9, "/images/book/oryx_and_crake.jpeg", 14.50m, 20, "Oryx and Crake" },
                    { 40, 10, "/images/book/a_clash_of_kings.jpeg", 12.99m, 25, "A Clash of Kings" },
                    { 41, 10, "/images/book/a_storm_of_swords.jpeg", 14.50m, 30, "A Storm of Swords" },
                    { 42, 10, "/images/book/a_feast_for_crows.jpeg", 13.99m, 28, "A Feast for Crows" },
                    { 43, 11, "/images/book/beloved.jpeg", 11.99m, 20, "Beloved" },
                    { 44, 12, "/images/book/americanah.jpeg", 13.50m, 25, "Americanah" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 4, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9860), 10.99m },
                    { 2, 2, new DateTime(2024, 4, 3, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9908), 25.00m },
                    { 3, 3, new DateTime(2024, 4, 2, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9913), 18.50m },
                    { 4, 4, new DateTime(2024, 4, 1, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9916), 32.75m },
                    { 5, 5, new DateTime(2024, 3, 31, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9919), 14.99m },
                    { 6, 6, new DateTime(2024, 3, 30, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9922), 20.25m },
                    { 7, 7, new DateTime(2024, 3, 29, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9925), 27.50m },
                    { 8, 8, new DateTime(2024, 3, 28, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9928), 45.75m },
                    { 9, 9, new DateTime(2024, 3, 27, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9931), 62.99m },
                    { 10, 10, new DateTime(2024, 3, 26, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9934), 28.50m },
                    { 11, 11, new DateTime(2024, 3, 25, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9937), 35.99m },
                    { 12, 12, new DateTime(2024, 3, 24, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9940), 52.25m },
                    { 13, 13, new DateTime(2024, 3, 23, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9944), 75.99m },
                    { 14, 14, new DateTime(2024, 3, 22, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9946), 42.75m },
                    { 15, 15, new DateTime(2024, 3, 21, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9949), 55.50m },
                    { 16, 12, new DateTime(2024, 3, 20, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9953), 38.25m },
                    { 17, 10, new DateTime(2024, 3, 19, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9956), 49.99m },
                    { 18, 8, new DateTime(2024, 3, 18, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9959), 65.75m },
                    { 19, 6, new DateTime(2024, 3, 17, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9962), 80.50m },
                    { 20, 10, new DateTime(2024, 3, 16, 21, 56, 29, 910, DateTimeKind.Local).AddTicks(9965), 95.25m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "BookId", "OrderId", "PricePerUnit", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 10.99m, 1 },
                    { 2, 2, 2, 12.50m, 2 },
                    { 3, 3, 3, 9.99m, 1 },
                    { 4, 4, 4, 12.50m, 3 },
                    { 5, 5, 5, 11.99m, 1 },
                    { 6, 6, 6, 14.99m, 2 },
                    { 7, 7, 7, 16.99m, 1 },
                    { 8, 8, 8, 13.99m, 2 },
                    { 9, 9, 9, 15.99m, 1 },
                    { 10, 10, 10, 14.50m, 2 },
                    { 11, 11, 11, 11.99m, 3 },
                    { 12, 12, 12, 10.99m, 2 },
                    { 13, 13, 13, 12.50m, 1 },
                    { 14, 14, 14, 15.99m, 2 },
                    { 15, 15, 15, 12.99m, 1 },
                    { 16, 16, 16, 9.99m, 3 },
                    { 17, 17, 17, 10.99m, 2 },
                    { 18, 18, 18, 8.99m, 1 },
                    { 19, 19, 19, 11.50m, 2 },
                    { 20, 20, 20, 7.99m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
