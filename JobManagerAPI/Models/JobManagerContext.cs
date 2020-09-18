using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using JobManagerAPI.Models;

namespace JobManagerAPI.Models
{
    public partial class JobManagerContext : DbContext
    {
        public JobManagerContext()
        {
        }

        public JobManagerContext(DbContextOptions<JobManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bankdetail> Bankdetails { get; set; }
        public virtual DbSet<MaterialTmp> MaterialTmps { get; set; }
        public virtual DbSet<PasteError> PasteErrors { get; set; }
        public virtual DbSet<TblAddress> TblAddresses { get; set; }
        public virtual DbSet<TblBagMstr> TblBagMstrs { get; set; }
        public virtual DbSet<TblBalancePayment> TblBalancePayments { get; set; }
        public virtual DbSet<TblBalanceSheet> TblBalanceSheets { get; set; }
        public virtual DbSet<TblCashbook> TblCashbooks { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblDamage> TblDamages { get; set; }
        public virtual DbSet<TblDate> TblDates { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEstimation> TblEstimations { get; set; }
        public virtual DbSet<TblEstimationProduction> TblEstimationProductions { get; set; }
        public virtual DbSet<TblEstimationWorker> TblEstimationWorkers { get; set; }
        public virtual DbSet<TblExpens> TblExpenses { get; set; }
        public virtual DbSet<TblExpenseMstr> TblExpenseMstrs { get; set; }
        public virtual DbSet<TblInvoice> TblInvoices { get; set; }
        public virtual DbSet<TblInvoiceItem> TblInvoiceItems { get; set; }
        public virtual DbSet<TblJobcard> TblJobcards { get; set; }
        public virtual DbSet<TblJobcardsWorker> TblJobcardsWorkers { get; set; }
        public virtual DbSet<TblMaterial> TblMaterials { get; set; }
        public virtual DbSet<TblMrn> TblMrns { get; set; }
        public virtual DbSet<TblMrnMstr> TblMrnMstrs { get; set; }
        public virtual DbSet<TblProdType> TblProdTypes { get; set; }
        public virtual DbSet<TblProduction> TblProductions { get; set; }
        public virtual DbSet<TblSuplier> TblSupliers { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblWestage> TblWestages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=JobManagerDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bankdetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.Ifsc)
                    .HasColumnName("IFSC")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MaterialTmp>(entity =>
            {
                entity.ToTable("material_tmp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(255);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Smts).HasColumnName("smts");

                entity.Property(e => e.SunitPrice).HasColumnName("Sunit_price");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.Typeofmaterial)
                    .HasColumnName("typeofmaterial")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UnitType)
                    .HasColumnName("unit_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PasteError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Paste Errors");

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.F6).HasMaxLength(255);
            });

            modelBuilder.Entity<TblAddress>(entity =>
            {
                entity.ToTable("tbl_address");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Add1)
                    .HasColumnName("add1")
                    .HasMaxLength(255);

                entity.Property(e => e.Add2)
                    .HasColumnName("add2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblBagMstr>(entity =>
            {
                entity.ToTable("tbl_bag_MSTR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bag)
                    .HasColumnName("bag")
                    .HasMaxLength(255);

                entity.Property(e => e.BagCode)
                    .HasColumnName("bag_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblBalancePayment>(entity =>
            {
                entity.ToTable("tbl_balance_payments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bal).HasColumnName("bal");

                entity.Property(e => e.Baldate)
                    .HasColumnName("baldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mrnid)
                    .HasColumnName("MRNID")
                    .HasMaxLength(255);

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.Suplier)
                    .HasColumnName("suplier")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalamt).HasColumnName("totalamt");
            });

            modelBuilder.Entity<TblBalanceSheet>(entity =>
            {
                entity.ToTable("tbl_BalanceSheet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.C1).HasColumnName("c1");

                entity.Property(e => e.C10).HasColumnName("c10");

                entity.Property(e => e.C2).HasColumnName("c2");

                entity.Property(e => e.C3).HasColumnName("c3");

                entity.Property(e => e.C4).HasColumnName("c4");

                entity.Property(e => e.C5).HasColumnName("c5");

                entity.Property(e => e.C6).HasColumnName("c6");

                entity.Property(e => e.C7).HasColumnName("c7");

                entity.Property(e => e.C8).HasColumnName("c8");

                entity.Property(e => e.C9).HasColumnName("c9");

                entity.Property(e => e.CTotal).HasColumnName("c_total");

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D10).HasColumnName("d10");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.D4).HasColumnName("d4");

                entity.Property(e => e.D5).HasColumnName("d5");

                entity.Property(e => e.D6).HasColumnName("d6");

                entity.Property(e => e.D7).HasColumnName("d7");

                entity.Property(e => e.D8).HasColumnName("d8");

                entity.Property(e => e.D9).HasColumnName("d9");

                entity.Property(e => e.DTotal).HasColumnName("d_total");

                entity.Property(e => e.Datec)
                    .HasColumnName("datec")
                    .HasColumnType("datetime");

                entity.Property(e => e.Particulars)
                    .HasColumnName("particulars")
                    .HasMaxLength(255);

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblCashbook>(entity =>
            {
                entity.ToTable("tbl_cashbook");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CAmount).HasColumnName("c_amount");

                entity.Property(e => e.CDetails)
                    .HasColumnName("c_details")
                    .HasMaxLength(255);

                entity.Property(e => e.CParticulars)
                    .HasColumnName("c_particulars")
                    .HasMaxLength(255);

                entity.Property(e => e.CRef)
                    .HasColumnName("c_ref")
                    .HasMaxLength(255);

                entity.Property(e => e.DAmount).HasColumnName("d_amount");

                entity.Property(e => e.DDetails)
                    .HasColumnName("d_details")
                    .HasMaxLength(255);

                entity.Property(e => e.DParticulars)
                    .HasColumnName("d_particulars")
                    .HasMaxLength(255);

                entity.Property(e => e.DRef)
                    .HasColumnName("d_ref")
                    .HasMaxLength(255);

                entity.Property(e => e.Datec)
                    .HasColumnName("datec")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aadhaar)
                    .HasColumnName("aadhaar")
                    .HasMaxLength(255);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAcNo)
                    .HasColumnName("bankAcNo")
                    .HasMaxLength(255);

                entity.Property(e => e.Br)
                    .HasColumnName("BR")
                    .HasMaxLength(255);

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(255);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(255);

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerID")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Gstno)
                    .HasColumnName("gstno")
                    .HasMaxLength(255);

                entity.Property(e => e.Ifsc)
                    .HasColumnName("ifsc")
                    .HasMaxLength(255);

                entity.Property(e => e.Pan)
                    .HasColumnName("pan")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceCity)
                    .HasColumnName("place_city")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblDamage>(entity =>
            {
                entity.ToTable("tbl_damages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(255);

                entity.Property(e => e.Mrnid)
                    .HasColumnName("MRNID")
                    .HasMaxLength(255);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_date");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tbl_employees");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dor)
                    .HasColumnName("DOR")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName).HasMaxLength(255);

                entity.Property(e => e.Exist).HasColumnName("exist");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<TblEstimation>(entity =>
            {
                entity.ToTable("tbl_estimation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balanceitems).HasColumnName("balanceitems");

                entity.Property(e => e.Closedby)
                    .HasColumnName("closedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Closedon)
                    .HasColumnName("closedon")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customerID")
                    .HasMaxLength(255);

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcode)
                    .HasColumnName("itemcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcost).HasColumnName("itemcost");

                entity.Property(e => e.JobType).HasMaxLength(255);

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialCost).HasColumnName("materialCost");

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.Profit).HasColumnName("profit");

                entity.Property(e => e.ProfitPer).HasColumnName("profit_per");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalamt).HasColumnName("totalamt");

                entity.Property(e => e.TotalamtWop).HasColumnName("totalamtWOP");

                entity.Property(e => e.Totalexp).HasColumnName("totalexp");

                entity.Property(e => e.Totalitems).HasColumnName("totalitems");

                entity.Property(e => e.Totallabchrg).HasColumnName("totallabchrg");

                entity.Property(e => e.Westage).HasColumnName("westage");
            });

            modelBuilder.Entity<TblEstimationProduction>(entity =>
            {
                entity.ToTable("tbl_estimation_production");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Dayofwork).HasColumnName("dayofwork");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.Jobtype)
                    .HasColumnName("jobtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Proddate)
                    .HasColumnName("proddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.Property(e => e.Workername)
                    .HasColumnName("workername")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblEstimationWorker>(entity =>
            {
                entity.ToTable("tbl_estimation_workers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PricePerUnit).HasColumnName("price_per_unit");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.Property(e => e.WorkerName)
                    .HasColumnName("workerName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblExpens>(entity =>
            {
                entity.ToTable("tbl_Expenses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cheque)
                    .HasColumnName("cheque")
                    .HasMaxLength(255);

                entity.Property(e => e.Expdate)
                    .HasColumnName("expdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expense)
                    .HasColumnName("expense")
                    .HasMaxLength(255);

                entity.Property(e => e.Particulars)
                    .HasColumnName("particulars")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalamt).HasColumnName("totalamt");

                entity.Property(e => e.Trantype).HasMaxLength(255);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedon)
                    .HasColumnName("updatedon")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblExpenseMstr>(entity =>
            {
                entity.ToTable("tbl_Expense_MSTR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpenceType)
                    .HasColumnName("expenceType")
                    .HasMaxLength(255);

                entity.Property(e => e.Fileds)
                    .HasColumnName("fileds")
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .HasColumnName("transactionType")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblInvoice>(entity =>
            {
                entity.ToTable("tbl_invoice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aftertax).HasColumnName("aftertax");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.Cgstp).HasColumnName("CGSTP");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customerID")
                    .HasMaxLength(255);

                entity.Property(e => e.Igst).HasColumnName("IGST");

                entity.Property(e => e.Igstp).HasColumnName("IGSTP");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");

                entity.Property(e => e.Invoicedate)
                    .HasColumnName("invoicedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Misc).HasColumnName("MISC");

                entity.Property(e => e.Paidamt).HasColumnName("paidamt");

                entity.Property(e => e.PaymentMode).HasMaxLength(255);

                entity.Property(e => e.Roundamount).HasColumnName("roundamount");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.Sgstp).HasColumnName("SGSTP");

                entity.Property(e => e.SupplyDate).HasColumnType("datetime");

                entity.Property(e => e.SupplyPlace).HasMaxLength(255);

                entity.Property(e => e.Totalamt).HasColumnName("totalamt");

                entity.Property(e => e.Tranno)
                    .HasColumnName("tranno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transport).HasColumnName("transport");

                entity.Property(e => e.TransportMode)
                    .HasColumnName("Transport_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedon)
                    .HasColumnName("updatedon")
                    .HasColumnType("datetime");

                entity.Property(e => e.VechicleNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<TblInvoiceItem>(entity =>
            {
                entity.ToTable("tbl_invoice_items");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(255);

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcode)
                    .HasColumnName("itemcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcost).HasColumnName("itemcost");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.Jobtype)
                    .HasColumnName("jobtype")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialType).HasMaxLength(255);

                entity.Property(e => e.Totalitems).HasColumnName("totalitems");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Wid).HasColumnName("wid");
            });

            modelBuilder.Entity<TblJobcard>(entity =>
            {
                entity.ToTable("tbl_jobcards");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balanceitems).HasColumnName("balanceitems");

                entity.Property(e => e.Closedby)
                    .HasColumnName("closedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Closedon)
                    .HasColumnName("closedon")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdon)
                    .HasColumnName("createdon")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customerID")
                    .HasMaxLength(255);

                entity.Property(e => e.Damages).HasColumnName("damages");

                entity.Property(e => e.Expected)
                    .HasColumnName("expected")
                    .HasColumnType("datetime");

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcode)
                    .HasColumnName("itemcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Itemcost).HasColumnName("itemcost");

                entity.Property(e => e.JobType).HasMaxLength(255);

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialCost).HasColumnName("materialCost");

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.Profit).HasColumnName("profit");

                entity.Property(e => e.ProfitPer).HasColumnName("profit_per");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalamt).HasColumnName("totalamt");

                entity.Property(e => e.TotalamtWop).HasColumnName("totalamtWOP");

                entity.Property(e => e.Totalexp).HasColumnName("totalexp");

                entity.Property(e => e.Totalitems).HasColumnName("totalitems");

                entity.Property(e => e.Totallabchrg).HasColumnName("totallabchrg");

                entity.Property(e => e.Westage).HasColumnName("westage");
            });

            modelBuilder.Entity<TblJobcardsWorker>(entity =>
            {
                entity.ToTable("tbl_jobcards_workers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PricePerUnit).HasColumnName("price_per_unit");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitType)
                    .HasColumnName("unit_type")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.Property(e => e.WorkerName)
                    .HasColumnName("workerName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblMaterial>(entity =>
            {
                entity.ToTable("tbl_materials");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Imgpath)
                    .HasColumnName("imgpath")
                    .HasMaxLength(255);

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblMrn>(entity =>
            {
                entity.ToTable("tbl_MRN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BalQty).HasColumnName("bal_qty");

                entity.Property(e => e.BillInvoiceDate)
                    .HasColumnName("bill_invoice_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillInvoiceNo)
                    .HasColumnName("bill_invoice_no")
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Damages).HasColumnName("damages");

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(255);

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(255);

                entity.Property(e => e.Mrnid)
                    .HasColumnName("MRNID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.PricePerUnit).HasColumnName("price_per_unit");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Smts).HasColumnName("smts");

                entity.Property(e => e.SunitPrice).HasColumnName("Sunit_price");

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");

                entity.Property(e => e.TranceportCharge).HasColumnName("tranceport_charge");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitType)
                    .HasColumnName("unit_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedon)
                    .HasColumnName("updatedon")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMrnMstr>(entity =>
            {
                entity.ToTable("tbl_MRN_MSTR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BalAmt).HasColumnName("bal_amt");

                entity.Property(e => e.BillInvoiceDate)
                    .HasColumnName("bill_invoice_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillInvoiceNo)
                    .HasColumnName("bill_invoice_no")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceAmt).HasColumnName("invoice_amt");

                entity.Property(e => e.MiscAmt).HasColumnName("misc_amt");

                entity.Property(e => e.Mrn).HasColumnName("MRN");

                entity.Property(e => e.Mrnid)
                    .HasColumnName("MRNID")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("payment_mode")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(255);

                entity.Property(e => e.SuplierId)
                    .HasColumnName("SuplierID")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalAmt).HasColumnName("total_amt");

                entity.Property(e => e.TranNo)
                    .HasColumnName("tran_no")
                    .HasMaxLength(255);

                entity.Property(e => e.TranceportCharge).HasColumnName("tranceport_charge");
            });

            modelBuilder.Entity<TblProdType>(entity =>
            {
                entity.ToTable("tbl_prodType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductionType)
                    .IsRequired()
                    .HasColumnName("productionType")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblProduction>(entity =>
            {
                entity.ToTable("tbl_production");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dayofwork).HasColumnName("dayofwork");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasMaxLength(255);

                entity.Property(e => e.Jobtype)
                    .HasColumnName("jobtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Proddate)
                    .HasColumnName("proddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.Property(e => e.Workername)
                    .HasColumnName("workername")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblSuplier>(entity =>
            {
                entity.ToTable("tbl_suplier");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aadhaar)
                    .HasColumnName("aadhaar")
                    .HasMaxLength(255);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(255);

                entity.Property(e => e.BankAcNo)
                    .HasColumnName("bankAcNo")
                    .HasMaxLength(255);

                entity.Property(e => e.Br)
                    .HasColumnName("BR")
                    .HasMaxLength(255);

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Gstno)
                    .HasColumnName("gstno")
                    .HasMaxLength(255);

                entity.Property(e => e.Ifsc)
                    .HasColumnName("ifsc")
                    .HasMaxLength(255);

                entity.Property(e => e.Pan)
                    .HasColumnName("pan")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceCity)
                    .HasColumnName("place_city")
                    .HasMaxLength(255);

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.Suplier)
                    .HasColumnName("suplier")
                    .HasMaxLength(255);

                entity.Property(e => e.SuplierId)
                    .IsRequired()
                    .HasColumnName("SuplierID")
                    .HasMaxLength(255);

                entity.Property(e => e.TinNo)
                    .HasColumnName("tin_no")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("accessLevel")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TblWestage>(entity =>
            {
                entity.ToTable("tbl_westage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bal).HasColumnName("bal");

                entity.Property(e => e.Material).HasMaxLength(255);

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Smts).HasColumnName("smts");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.Property(e => e.Wrkid)
                    .HasColumnName("WRKID")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<JobManagerAPI.Models.TblUsers> TblUsers_1 { get; set; }
    }
}
