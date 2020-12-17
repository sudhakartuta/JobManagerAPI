using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobManagerAPI.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bankdetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(maxLength: 255, nullable: true),
                    AccountNo = table.Column<string>(maxLength: 255, nullable: true),
                    IFSC = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankdetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "material_tmp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    typeofmaterial = table.Column<string>(maxLength: 255, nullable: true),
                    material = table.Column<string>(maxLength: 255, nullable: true),
                    code = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    unit_type = table.Column<string>(maxLength: 255, nullable: true),
                    unit_price = table.Column<double>(nullable: true),
                    total_amt = table.Column<double>(nullable: true),
                    updatedby = table.Column<string>(maxLength: 255, nullable: true),
                    L = table.Column<double>(nullable: true),
                    W = table.Column<double>(nullable: true),
                    smts = table.Column<double>(nullable: true),
                    Sunit_price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_tmp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Paste Errors",
                columns: table => new
                {
                    F1 = table.Column<double>(nullable: true),
                    F2 = table.Column<string>(maxLength: 255, nullable: true),
                    F3 = table.Column<string>(maxLength: 255, nullable: true),
                    F4 = table.Column<string>(maxLength: 255, nullable: true),
                    F5 = table.Column<string>(maxLength: 255, nullable: true),
                    F6 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_address",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    add1 = table.Column<string>(maxLength: 255, nullable: true),
                    add2 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_address", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_bag_MSTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bag = table.Column<string>(maxLength: 255, nullable: true),
                    bag_code = table.Column<string>(maxLength: 255, nullable: true),
                    image = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bag_MSTR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_balance_payments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baldate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MRNID = table.Column<string>(maxLength: 255, nullable: true),
                    suplier = table.Column<string>(maxLength: 255, nullable: true),
                    totalamt = table.Column<double>(nullable: true),
                    paid = table.Column<double>(nullable: true),
                    bal = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_balance_payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BalanceSheet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datec = table.Column<DateTime>(type: "datetime", nullable: true),
                    particulars = table.Column<string>(maxLength: 255, nullable: true),
                    @ref = table.Column<string>(name: "ref", maxLength: 255, nullable: true),
                    d1 = table.Column<double>(nullable: true),
                    d2 = table.Column<double>(nullable: true),
                    d3 = table.Column<double>(nullable: true),
                    d4 = table.Column<double>(nullable: true),
                    d5 = table.Column<double>(nullable: true),
                    d6 = table.Column<double>(nullable: true),
                    d7 = table.Column<double>(nullable: true),
                    d8 = table.Column<double>(nullable: true),
                    d9 = table.Column<double>(nullable: true),
                    d10 = table.Column<double>(nullable: true),
                    d_total = table.Column<double>(nullable: true),
                    c1 = table.Column<double>(nullable: true),
                    c2 = table.Column<double>(nullable: true),
                    c3 = table.Column<double>(nullable: true),
                    c4 = table.Column<double>(nullable: true),
                    c5 = table.Column<double>(nullable: true),
                    c6 = table.Column<double>(nullable: true),
                    c7 = table.Column<double>(nullable: true),
                    c8 = table.Column<double>(nullable: true),
                    c9 = table.Column<double>(nullable: true),
                    c10 = table.Column<double>(nullable: true),
                    c_total = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BalanceSheet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_cashbook",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datec = table.Column<DateTime>(type: "datetime", nullable: true),
                    d_particulars = table.Column<string>(maxLength: 255, nullable: true),
                    d_details = table.Column<string>(maxLength: 255, nullable: true),
                    d_ref = table.Column<string>(maxLength: 255, nullable: true),
                    d_amount = table.Column<double>(nullable: true),
                    c_particulars = table.Column<string>(maxLength: 255, nullable: true),
                    c_details = table.Column<string>(maxLength: 255, nullable: true),
                    c_ref = table.Column<string>(maxLength: 255, nullable: true),
                    c_amount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cashbook", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(nullable: true),
                    customerID = table.Column<string>(maxLength: 255, nullable: false),
                    customer = table.Column<string>(maxLength: 255, nullable: true),
                    contact_no = table.Column<string>(maxLength: 255, nullable: true),
                    email = table.Column<string>(maxLength: 255, nullable: true),
                    address = table.Column<string>(maxLength: 255, nullable: true),
                    bank = table.Column<string>(maxLength: 255, nullable: true),
                    bankAcNo = table.Column<string>(maxLength: 255, nullable: true),
                    branch = table.Column<string>(maxLength: 255, nullable: true),
                    ifsc = table.Column<string>(maxLength: 255, nullable: true),
                    gstno = table.Column<string>(maxLength: 255, nullable: true),
                    pan = table.Column<string>(maxLength: 255, nullable: true),
                    aadhaar = table.Column<string>(maxLength: 255, nullable: true),
                    place_city = table.Column<string>(maxLength: 255, nullable: true),
                    BR = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_damages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime", nullable: true),
                    MRNID = table.Column<string>(maxLength: 255, nullable: true),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    materialType = table.Column<string>(maxLength: 255, nullable: true),
                    material = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<string>(maxLength: 255, nullable: true),
                    remarks = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_damages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_date",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpID = table.Column<int>(nullable: true),
                    EmpName = table.Column<string>(maxLength: 255, nullable: true),
                    phone = table.Column<string>(maxLength: 255, nullable: true),
                    address = table.Column<string>(maxLength: 255, nullable: true),
                    exist = table.Column<bool>(nullable: false),
                    DOJ = table.Column<DateTime>(type: "datetime", nullable: true),
                    DOR = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(maxLength: 255, nullable: true),
                    salary = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_estimation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jobcardno = table.Column<int>(nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<string>(maxLength: 255, nullable: true),
                    JobType = table.Column<string>(maxLength: 255, nullable: true),
                    itemcode = table.Column<string>(maxLength: 255, nullable: true),
                    item = table.Column<string>(maxLength: 255, nullable: true),
                    totalitems = table.Column<double>(nullable: true),
                    balanceitems = table.Column<double>(nullable: true),
                    itemcost = table.Column<double>(nullable: true),
                    materialCost = table.Column<double>(nullable: true),
                    totalexp = table.Column<double>(nullable: true),
                    totallabchrg = table.Column<double>(nullable: true),
                    MRP = table.Column<double>(nullable: true),
                    totalamtWOP = table.Column<double>(nullable: true),
                    profit_per = table.Column<int>(nullable: true),
                    profit = table.Column<double>(nullable: true),
                    totalamt = table.Column<double>(nullable: true),
                    createdon = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(maxLength: 255, nullable: true),
                    status = table.Column<string>(maxLength: 255, nullable: true),
                    closedon = table.Column<DateTime>(type: "datetime", nullable: true),
                    closedby = table.Column<string>(maxLength: 255, nullable: true),
                    westage = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_estimation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_estimation_production",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UID = table.Column<int>(nullable: false),
                    proddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    workerID = table.Column<int>(nullable: true),
                    workername = table.Column<string>(maxLength: 255, nullable: true),
                    jobtype = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    dayofwork = table.Column<double>(nullable: true),
                    cost = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_estimation_production", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_estimation_workers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TID = table.Column<int>(nullable: false),
                    materialID = table.Column<int>(nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    workerID = table.Column<int>(nullable: true),
                    workerName = table.Column<string>(maxLength: 255, nullable: true),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    materialType = table.Column<string>(maxLength: 255, nullable: true),
                    material = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    price_per_unit = table.Column<double>(nullable: true),
                    price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_estimation_workers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Expense_MSTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transactionType = table.Column<string>(maxLength: 255, nullable: true),
                    expenceType = table.Column<string>(maxLength: 255, nullable: true),
                    fileds = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Expense_MSTR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Expenses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Trantype = table.Column<string>(maxLength: 255, nullable: true),
                    expense = table.Column<string>(maxLength: 255, nullable: true),
                    totalamt = table.Column<double>(nullable: true),
                    updatedon = table.Column<DateTime>(type: "datetime", nullable: true),
                    updatedby = table.Column<string>(maxLength: 255, nullable: true),
                    particulars = table.Column<string>(maxLength: 255, nullable: true),
                    cheque = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Expenses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_invoice",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoiceID = table.Column<int>(nullable: true),
                    invoice = table.Column<string>(maxLength: 255, nullable: true),
                    invoicedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    customerID = table.Column<string>(maxLength: 255, nullable: true),
                    totalamt = table.Column<double>(nullable: true),
                    aftertax = table.Column<double>(nullable: true),
                    roundamount = table.Column<double>(nullable: true),
                    paidamt = table.Column<double>(nullable: true),
                    balance = table.Column<double>(nullable: true),
                    CGSTP = table.Column<double>(nullable: true),
                    CGST = table.Column<double>(nullable: true),
                    SGSTP = table.Column<double>(nullable: true),
                    SGST = table.Column<double>(nullable: true),
                    IGSTP = table.Column<double>(nullable: true),
                    IGST = table.Column<double>(nullable: true),
                    MISC = table.Column<double>(nullable: true),
                    transport = table.Column<double>(nullable: true),
                    Transport_mode = table.Column<string>(maxLength: 255, nullable: true),
                    VechicleNumber = table.Column<string>(maxLength: 255, nullable: true),
                    SupplyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SupplyPlace = table.Column<string>(maxLength: 255, nullable: true),
                    PaymentMode = table.Column<string>(maxLength: 255, nullable: true),
                    tranno = table.Column<string>(maxLength: 255, nullable: true),
                    updatedby = table.Column<string>(maxLength: 255, nullable: true),
                    updatedon = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_invoice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_invoice_items",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wid = table.Column<int>(nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    invoice = table.Column<string>(maxLength: 255, nullable: true),
                    jobtype = table.Column<string>(maxLength: 255, nullable: true),
                    MaterialType = table.Column<string>(maxLength: 255, nullable: true),
                    itemcode = table.Column<string>(maxLength: 255, nullable: true),
                    item = table.Column<string>(maxLength: 255, nullable: true),
                    itemcost = table.Column<double>(nullable: true),
                    totalitems = table.Column<double>(nullable: true),
                    amount = table.Column<double>(nullable: true),
                    updatedby = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_invoice_items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_jobcards",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jobcardno = table.Column<int>(nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    customerID = table.Column<string>(maxLength: 255, nullable: true),
                    JobType = table.Column<string>(maxLength: 255, nullable: true),
                    itemcode = table.Column<string>(maxLength: 255, nullable: true),
                    item = table.Column<string>(maxLength: 255, nullable: true),
                    totalitems = table.Column<double>(nullable: true),
                    balanceitems = table.Column<double>(nullable: true),
                    damages = table.Column<double>(nullable: true),
                    itemcost = table.Column<double>(nullable: true),
                    materialCost = table.Column<double>(nullable: true),
                    westage = table.Column<double>(nullable: true),
                    totalexp = table.Column<double>(nullable: true),
                    totallabchrg = table.Column<double>(nullable: true),
                    MRP = table.Column<double>(nullable: true),
                    totalamtWOP = table.Column<double>(nullable: true),
                    profit_per = table.Column<int>(nullable: true),
                    profit = table.Column<double>(nullable: true),
                    totalamt = table.Column<double>(nullable: true),
                    createdon = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdby = table.Column<string>(maxLength: 255, nullable: true),
                    status = table.Column<string>(maxLength: 255, nullable: true),
                    closedon = table.Column<DateTime>(type: "datetime", nullable: true),
                    closedby = table.Column<string>(maxLength: 255, nullable: true),
                    expected = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_jobcards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_jobcards_workers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    materialID = table.Column<int>(nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    workerID = table.Column<int>(nullable: true),
                    workerName = table.Column<string>(maxLength: 255, nullable: true),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    materialType = table.Column<string>(maxLength: 255, nullable: true),
                    material = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    price_per_unit = table.Column<double>(nullable: true),
                    price = table.Column<double>(nullable: true),
                    unit_type = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_jobcards_workers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_materials",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(maxLength: 255, nullable: false),
                    MaterialType = table.Column<string>(maxLength: 255, nullable: false),
                    code = table.Column<string>(maxLength: 255, nullable: false),
                    Material = table.Column<string>(maxLength: 255, nullable: false),
                    imgpath = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_materials", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MRN",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRNID = table.Column<string>(maxLength: 255, nullable: true),
                    materialID = table.Column<int>(nullable: true),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    materialType = table.Column<string>(maxLength: 255, nullable: true),
                    bill_invoice_no = table.Column<string>(maxLength: 255, nullable: true),
                    bill_invoice_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    material = table.Column<string>(maxLength: 255, nullable: true),
                    code = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    bal_qty = table.Column<double>(nullable: true),
                    damages = table.Column<double>(nullable: true),
                    unit_type = table.Column<string>(maxLength: 255, nullable: true),
                    price_per_unit = table.Column<double>(nullable: true),
                    MRP = table.Column<double>(nullable: true),
                    tranceport_charge = table.Column<double>(nullable: true),
                    total_amt = table.Column<double>(nullable: true),
                    remarks = table.Column<string>(nullable: true),
                    updatedby = table.Column<string>(maxLength: 255, nullable: true),
                    updatedon = table.Column<DateTime>(type: "datetime", nullable: true),
                    L = table.Column<double>(nullable: true),
                    W = table.Column<double>(nullable: true),
                    smts = table.Column<double>(nullable: true),
                    Sunit_price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MRN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MRN_MSTR",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRN = table.Column<int>(nullable: true),
                    MRNID = table.Column<string>(maxLength: 255, nullable: true),
                    SuplierID = table.Column<string>(maxLength: 255, nullable: true),
                    bill_invoice_no = table.Column<string>(maxLength: 255, nullable: true),
                    bill_invoice_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    invoice_amt = table.Column<double>(nullable: true),
                    misc_amt = table.Column<double>(nullable: true),
                    tranceport_charge = table.Column<double>(nullable: true),
                    paid_amt = table.Column<double>(nullable: true),
                    payment_mode = table.Column<string>(maxLength: 255, nullable: true),
                    tran_no = table.Column<string>(maxLength: 255, nullable: true),
                    total_amt = table.Column<int>(nullable: true),
                    bal_amt = table.Column<int>(nullable: true),
                    remarks = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MRN_MSTR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_prodType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productionType = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_prodType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_production",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    JobcardID = table.Column<string>(maxLength: 255, nullable: true),
                    workerID = table.Column<int>(nullable: true),
                    workername = table.Column<string>(maxLength: 255, nullable: true),
                    jobtype = table.Column<string>(maxLength: 255, nullable: true),
                    qty = table.Column<double>(nullable: true),
                    dayofwork = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_production", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_suplier",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SID = table.Column<int>(nullable: true),
                    SuplierID = table.Column<string>(maxLength: 255, nullable: false),
                    suplier = table.Column<string>(maxLength: 255, nullable: true),
                    tin_no = table.Column<string>(maxLength: 255, nullable: true),
                    contact_no = table.Column<string>(maxLength: 255, nullable: true),
                    email = table.Column<string>(maxLength: 255, nullable: true),
                    address = table.Column<string>(maxLength: 255, nullable: true),
                    bank = table.Column<string>(maxLength: 255, nullable: true),
                    bankAcNo = table.Column<string>(maxLength: 255, nullable: true),
                    branch = table.Column<string>(maxLength: 255, nullable: true),
                    ifsc = table.Column<string>(maxLength: 255, nullable: true),
                    gstno = table.Column<string>(maxLength: 255, nullable: true),
                    pan = table.Column<string>(maxLength: 255, nullable: true),
                    aadhaar = table.Column<string>(maxLength: 255, nullable: true),
                    place_city = table.Column<string>(maxLength: 255, nullable: true),
                    BR = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_suplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(maxLength: 50, nullable: true),
                    userName = table.Column<string>(maxLength: 50, nullable: true),
                    password = table.Column<string>(maxLength: 50, nullable: true),
                    accessLevel = table.Column<string>(maxLength: 50, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    Token = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_westage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WRKID = table.Column<string>(maxLength: 255, nullable: true),
                    MID = table.Column<string>(maxLength: 255, nullable: true),
                    Material = table.Column<string>(maxLength: 255, nullable: true),
                    W = table.Column<double>(nullable: true),
                    L = table.Column<double>(nullable: true),
                    smts = table.Column<double>(nullable: true),
                    unitprice = table.Column<double>(nullable: true),
                    units = table.Column<double>(nullable: true),
                    bal = table.Column<double>(nullable: true),
                    price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_westage", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bankdetails");

            migrationBuilder.DropTable(
                name: "material_tmp");

            migrationBuilder.DropTable(
                name: "Paste Errors");

            migrationBuilder.DropTable(
                name: "tbl_address");

            migrationBuilder.DropTable(
                name: "tbl_bag_MSTR");

            migrationBuilder.DropTable(
                name: "tbl_balance_payments");

            migrationBuilder.DropTable(
                name: "tbl_BalanceSheet");

            migrationBuilder.DropTable(
                name: "tbl_cashbook");

            migrationBuilder.DropTable(
                name: "tbl_customer");

            migrationBuilder.DropTable(
                name: "tbl_damages");

            migrationBuilder.DropTable(
                name: "tbl_date");

            migrationBuilder.DropTable(
                name: "tbl_employees");

            migrationBuilder.DropTable(
                name: "tbl_estimation");

            migrationBuilder.DropTable(
                name: "tbl_estimation_production");

            migrationBuilder.DropTable(
                name: "tbl_estimation_workers");

            migrationBuilder.DropTable(
                name: "tbl_Expense_MSTR");

            migrationBuilder.DropTable(
                name: "tbl_Expenses");

            migrationBuilder.DropTable(
                name: "tbl_invoice");

            migrationBuilder.DropTable(
                name: "tbl_invoice_items");

            migrationBuilder.DropTable(
                name: "tbl_jobcards");

            migrationBuilder.DropTable(
                name: "tbl_jobcards_workers");

            migrationBuilder.DropTable(
                name: "tbl_materials");

            migrationBuilder.DropTable(
                name: "tbl_MRN");

            migrationBuilder.DropTable(
                name: "tbl_MRN_MSTR");

            migrationBuilder.DropTable(
                name: "tbl_prodType");

            migrationBuilder.DropTable(
                name: "tbl_production");

            migrationBuilder.DropTable(
                name: "tbl_suplier");

            migrationBuilder.DropTable(
                name: "tbl_users");

            migrationBuilder.DropTable(
                name: "tbl_westage");
        }
    }
}
