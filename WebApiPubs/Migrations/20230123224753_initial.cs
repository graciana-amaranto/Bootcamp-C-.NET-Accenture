﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPubs.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    au_id = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    au_lname = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    au_fname = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    phone = table.Column<string>(unicode: false, fixedLength: true, maxLength: 12, nullable: false, defaultValueSql: "('UNKNOWN')"),
                    address = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    zip = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    contract = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_auidind", x => x.au_id);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    job_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_desc = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('New Position - title not formalized yet')"),
                    min_lvl = table.Column<byte>(nullable: false),
                    max_lvl = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__jobs__6E32B6A54E73B254", x => x.job_id);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    pub_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    pub_name = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    country = table.Column<string>(unicode: false, maxLength: 30, nullable: true, defaultValueSql: "('USA')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_pubind", x => x.pub_id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    stor_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    stor_name = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    stor_address = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    zip = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPK_storeid", x => x.stor_id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    emp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 9, nullable: false),
                    fname = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    minit = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    lname = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    job_id = table.Column<short>(nullable: false, defaultValueSql: "((1))"),
                    job_lvl = table.Column<byte>(nullable: true, defaultValueSql: "((10))"),
                    pub_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9952')"),
                    hire_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emp_id", x => x.emp_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__employee__job_id__5BE2A6F2",
                        column: x => x.job_id,
                        principalTable: "jobs",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__employee__pub_id__5EBF139D",
                        column: x => x.pub_id,
                        principalTable: "publishers",
                        principalColumn: "pub_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pub_info",
                columns: table => new
                {
                    pub_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    logo = table.Column<byte[]>(type: "image", nullable: true),
                    pr_info = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_pubinfo", x => x.pub_id);
                    table.ForeignKey(
                        name: "FK__pub_info__pub_id__571DF1D5",
                        column: x => x.pub_id,
                        principalTable: "publishers",
                        principalColumn: "pub_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    title_id = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    title = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    type = table.Column<string>(unicode: false, fixedLength: true, maxLength: 12, nullable: false, defaultValueSql: "('UNDECIDED')"),
                    pub_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    advance = table.Column<decimal>(type: "money", nullable: true),
                    royalty = table.Column<int>(nullable: true),
                    ytd_sales = table.Column<int>(nullable: true),
                    notes = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    pubdate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_titleidind", x => x.title_id);
                    table.ForeignKey(
                        name: "FK__titles__pub_id__412EB0B6",
                        column: x => x.pub_id,
                        principalTable: "publishers",
                        principalColumn: "pub_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "discounts",
                columns: table => new
                {
                    discounttype = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    stor_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    lowqty = table.Column<short>(nullable: true),
                    highqty = table.Column<short>(nullable: true),
                    discount = table.Column<decimal>(type: "decimal(4, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__discounts__stor___4F7CD00D",
                        column: x => x.stor_id,
                        principalTable: "stores",
                        principalColumn: "stor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roysched",
                columns: table => new
                {
                    title_id = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    lorange = table.Column<int>(nullable: true),
                    hirange = table.Column<int>(nullable: true),
                    royalty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__roysched__title___4D94879B",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    stor_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ord_num = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    title_id = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    ord_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    qty = table.Column<short>(nullable: false),
                    payterms = table.Column<string>(unicode: false, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_sales", x => new { x.stor_id, x.ord_num, x.title_id });
                    table.ForeignKey(
                        name: "FK__sales__stor_id__4AB81AF0",
                        column: x => x.stor_id,
                        principalTable: "stores",
                        principalColumn: "stor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__sales__title_id__4BAC3F29",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "titleauthor",
                columns: table => new
                {
                    au_id = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    title_id = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    au_ord = table.Column<byte>(nullable: true),
                    royaltyper = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UPKCL_taind", x => new { x.au_id, x.title_id });
                    table.ForeignKey(
                        name: "FK__titleauth__au_id__44FF419A",
                        column: x => x.au_id,
                        principalTable: "authors",
                        principalColumn: "au_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__titleauth__title__45F365D3",
                        column: x => x.title_id,
                        principalTable: "titles",
                        principalColumn: "title_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "aunmind",
                table: "authors",
                columns: new[] { "au_lname", "au_fname" });

            migrationBuilder.CreateIndex(
                name: "IX_discounts_stor_id",
                table: "discounts",
                column: "stor_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_job_id",
                table: "employee",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_pub_id",
                table: "employee",
                column: "pub_id");

            migrationBuilder.CreateIndex(
                name: "employee_ind",
                table: "employee",
                columns: new[] { "lname", "fname", "minit" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "titleidind",
                table: "roysched",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "titleidind",
                table: "sales",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "auidind",
                table: "titleauthor",
                column: "au_id");

            migrationBuilder.CreateIndex(
                name: "titleidind",
                table: "titleauthor",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "IX_titles_pub_id",
                table: "titles",
                column: "pub_id");

            migrationBuilder.CreateIndex(
                name: "titleind",
                table: "titles",
                column: "title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "discounts");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "pub_info");

            migrationBuilder.DropTable(
                name: "roysched");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "titleauthor");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "titles");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
