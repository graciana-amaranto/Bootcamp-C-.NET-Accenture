﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiPubs.Models;

namespace WebApiPubs.Migrations
{
    [DbContext(typeof(PubsContext))]
    partial class PubsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiPubs.Models.Authors", b =>
                {
                    b.Property<string>("AuId")
                        .HasColumnName("au_id")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("AuFname")
                        .IsRequired()
                        .HasColumnName("au_fname")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("AuLname")
                        .IsRequired()
                        .HasColumnName("au_lname")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<bool>("Contract")
                        .HasColumnName("contract")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("phone")
                        .HasColumnType("char(12)")
                        .HasDefaultValueSql("('UNKNOWN')")
                        .IsFixedLength(true)
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("Zip")
                        .HasColumnName("zip")
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("AuId")
                        .HasName("UPKCL_auidind");

                    b.HasIndex("AuLname", "AuFname")
                        .HasName("aunmind");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("WebApiPubs.Models.Discounts", b =>
                {
                    b.Property<decimal>("Discount")
                        .HasColumnName("discount")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<string>("Discounttype")
                        .IsRequired()
                        .HasColumnName("discounttype")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<short?>("Highqty")
                        .HasColumnName("highqty")
                        .HasColumnType("smallint");

                    b.Property<short?>("Lowqty")
                        .HasColumnName("lowqty")
                        .HasColumnType("smallint");

                    b.Property<string>("StorId")
                        .HasColumnName("stor_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.HasIndex("StorId");

                    b.ToTable("discounts");
                });

            modelBuilder.Entity("WebApiPubs.Models.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasColumnName("emp_id")
                        .HasColumnType("char(9)")
                        .IsFixedLength(true)
                        .HasMaxLength(9)
                        .IsUnicode(false);

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnName("fname")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("hire_date")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<short>("JobId")
                        .HasColumnName("job_id")
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<byte?>("JobLvl")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("job_lvl")
                        .HasColumnType("tinyint")
                        .HasDefaultValueSql("((10))");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnName("lname")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Minit")
                        .HasColumnName("minit")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("PubId")
                        .IsRequired()
                        .HasColumnName("pub_id")
                        .HasColumnType("char(4)")
                        .HasDefaultValueSql("('9952')")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.HasKey("EmpId")
                        .HasName("PK_emp_id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("JobId");

                    b.HasIndex("PubId");

                    b.HasIndex("Lname", "Fname", "Minit")
                        .HasName("employee_ind")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("employee");
                });

            modelBuilder.Entity("WebApiPubs.Models.Jobs", b =>
                {
                    b.Property<short>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("job_id")
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobDesc")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("job_desc")
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('New Position - title not formalized yet')")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<byte>("MaxLvl")
                        .HasColumnName("max_lvl")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MinLvl")
                        .HasColumnName("min_lvl")
                        .HasColumnType("tinyint");

                    b.HasKey("JobId")
                        .HasName("PK__jobs__6E32B6A54E73B254");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("WebApiPubs.Models.PubInfo", b =>
                {
                    b.Property<string>("PubId")
                        .HasColumnName("pub_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<byte[]>("Logo")
                        .HasColumnName("logo")
                        .HasColumnType("image");

                    b.Property<string>("PrInfo")
                        .HasColumnName("pr_info")
                        .HasColumnType("text");

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubinfo");

                    b.ToTable("pub_info");
                });

            modelBuilder.Entity("WebApiPubs.Models.Publisher", b =>
                {
                    b.Property<string>("PubId")
                        .HasColumnName("pub_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("country")
                        .HasColumnType("varchar(30)")
                        .HasDefaultValueSql("('USA')")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("PubName")
                        .HasColumnName("pub_name")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("PubId")
                        .HasName("UPKCL_pubind");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("WebApiPubs.Models.Roysched", b =>
                {
                    b.Property<int?>("Hirange")
                        .HasColumnName("hirange")
                        .HasColumnType("int");

                    b.Property<int?>("Lorange")
                        .HasColumnName("lorange")
                        .HasColumnType("int");

                    b.Property<int?>("Royalty")
                        .HasColumnName("royalty")
                        .HasColumnType("int");

                    b.Property<string>("TitleId")
                        .IsRequired()
                        .HasColumnName("title_id")
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.HasIndex("TitleId")
                        .HasName("titleidind");

                    b.ToTable("roysched");
                });

            modelBuilder.Entity("WebApiPubs.Models.Sales", b =>
                {
                    b.Property<string>("StorId")
                        .HasColumnName("stor_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("OrdNum")
                        .HasColumnName("ord_num")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TitleId")
                        .HasColumnName("title_id")
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<DateTime>("OrdDate")
                        .HasColumnName("ord_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Payterms")
                        .IsRequired()
                        .HasColumnName("payterms")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<short>("Qty")
                        .HasColumnName("qty")
                        .HasColumnType("smallint");

                    b.HasKey("StorId", "OrdNum", "TitleId")
                        .HasName("UPKCL_sales");

                    b.HasIndex("TitleId")
                        .HasName("titleidind");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("WebApiPubs.Models.Stores", b =>
                {
                    b.Property<string>("StorId")
                        .HasColumnName("stor_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("StorAddress")
                        .HasColumnName("stor_address")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("StorName")
                        .HasColumnName("stor_name")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("Zip")
                        .HasColumnName("zip")
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("StorId")
                        .HasName("UPK_storeid");

                    b.ToTable("stores");
                });

            modelBuilder.Entity("WebApiPubs.Models.Titleauthor", b =>
                {
                    b.Property<string>("AuId")
                        .HasColumnName("au_id")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.Property<string>("TitleId")
                        .HasColumnName("title_id")
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<byte?>("AuOrd")
                        .HasColumnName("au_ord")
                        .HasColumnType("tinyint");

                    b.Property<int?>("Royaltyper")
                        .HasColumnName("royaltyper")
                        .HasColumnType("int");

                    b.HasKey("AuId", "TitleId")
                        .HasName("UPKCL_taind");

                    b.HasIndex("AuId")
                        .HasName("auidind");

                    b.HasIndex("TitleId")
                        .HasName("titleidind");

                    b.ToTable("titleauthor");
                });

            modelBuilder.Entity("WebApiPubs.Models.Titles", b =>
                {
                    b.Property<string>("TitleId")
                        .HasColumnName("title_id")
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<decimal?>("Advance")
                        .HasColumnName("advance")
                        .HasColumnType("money");

                    b.Property<string>("Notes")
                        .HasColumnName("notes")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<decimal?>("Price")
                        .HasColumnName("price")
                        .HasColumnType("money");

                    b.Property<string>("PubId")
                        .HasColumnName("pub_id")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<DateTime>("Pubdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("pubdate")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Royalty")
                        .HasColumnName("royalty")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("Type")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("type")
                        .HasColumnType("char(12)")
                        .HasDefaultValueSql("('UNDECIDED')")
                        .IsFixedLength(true)
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<int?>("YtdSales")
                        .HasColumnName("ytd_sales")
                        .HasColumnType("int");

                    b.HasKey("TitleId")
                        .HasName("UPKCL_titleidind");

                    b.HasIndex("PubId");

                    b.HasIndex("Title")
                        .HasName("titleind");

                    b.ToTable("titles");
                });

            modelBuilder.Entity("WebApiPubs.Models.Discounts", b =>
                {
                    b.HasOne("WebApiPubs.Models.Stores", "Stor")
                        .WithMany()
                        .HasForeignKey("StorId")
                        .HasConstraintName("FK__discounts__stor___4F7CD00D");
                });

            modelBuilder.Entity("WebApiPubs.Models.Employee", b =>
                {
                    b.HasOne("WebApiPubs.Models.Jobs", "Job")
                        .WithMany("Employee")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__employee__job_id__5BE2A6F2")
                        .IsRequired();

                    b.HasOne("WebApiPubs.Models.Publisher", "Pub")
                        .WithMany("Employee")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__employee__pub_id__5EBF139D")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiPubs.Models.PubInfo", b =>
                {
                    b.HasOne("WebApiPubs.Models.Publisher", "Pub")
                        .WithOne("PubInfo")
                        .HasForeignKey("WebApiPubs.Models.PubInfo", "PubId")
                        .HasConstraintName("FK__pub_info__pub_id__571DF1D5")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiPubs.Models.Roysched", b =>
                {
                    b.HasOne("WebApiPubs.Models.Titles", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__roysched__title___4D94879B")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiPubs.Models.Sales", b =>
                {
                    b.HasOne("WebApiPubs.Models.Stores", "Stor")
                        .WithMany("Sales")
                        .HasForeignKey("StorId")
                        .HasConstraintName("FK__sales__stor_id__4AB81AF0")
                        .IsRequired();

                    b.HasOne("WebApiPubs.Models.Titles", "Title")
                        .WithMany("Sales")
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__sales__title_id__4BAC3F29")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiPubs.Models.Titleauthor", b =>
                {
                    b.HasOne("WebApiPubs.Models.Authors", "Au")
                        .WithMany("Titleauthor")
                        .HasForeignKey("AuId")
                        .HasConstraintName("FK__titleauth__au_id__44FF419A")
                        .IsRequired();

                    b.HasOne("WebApiPubs.Models.Titles", "Title")
                        .WithMany("Titleauthor")
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK__titleauth__title__45F365D3")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiPubs.Models.Titles", b =>
                {
                    b.HasOne("WebApiPubs.Models.Publisher", "Pub")
                        .WithMany("Titles")
                        .HasForeignKey("PubId")
                        .HasConstraintName("FK__titles__pub_id__412EB0B6");
                });
#pragma warning restore 612, 618
        }
    }
}
