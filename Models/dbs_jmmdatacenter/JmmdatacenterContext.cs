using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class JmmdatacenterContext : DbContext
{
    public JmmdatacenterContext()
    {
    }

    public JmmdatacenterContext(DbContextOptions<JmmdatacenterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Arearegion> Arearegions { get; set; }

    public virtual DbSet<ArearegionStaff> ArearegionStaffs { get; set; }

    public virtual DbSet<Areastaff> Areastaffs { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Attgoanywhere> Attgoanywheres { get; set; }

    public virtual DbSet<Attleave> Attleaves { get; set; }

    public virtual DbSet<AttleaveApv> AttleaveApvs { get; set; }

    public virtual DbSet<AttleaveImg> AttleaveImgs { get; set; }

    public virtual DbSet<Attweekend> Attweekends { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<BrandSub> BrandSubs { get; set; }

    public virtual DbSet<Cnndatum> Cnndata { get; set; }

    public virtual DbSet<ComGroup> ComGroups { get; set; }

    public virtual DbSet<ComGroupmember> ComGroupmembers { get; set; }

    public virtual DbSet<Cpndatamaster> Cpndatamasters { get; set; }

    public virtual DbSet<Cpndatum> Cpndata { get; set; }

    public virtual DbSet<Cpnprodtarget> Cpnprodtargets { get; set; }

    public virtual DbSet<CpnprodtargetDatum> CpnprodtargetData { get; set; }

    public virtual DbSet<Cpnstatus> Cpnstatuses { get; set; }

    public virtual DbSet<Crmaddr> Crmaddrs { get; set; }

    public virtual DbSet<Crmcontact> Crmcontacts { get; set; }

    public virtual DbSet<CrmproductFback> CrmproductFbacks { get; set; }

    public virtual DbSet<Crmregi> Crmregis { get; set; }

    public virtual DbSet<Crmsegment> Crmsegments { get; set; }

    public virtual DbSet<Definedatum> Definedata { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EdoAw> EdoAws { get; set; }

    public virtual DbSet<EdoDocaccept> EdoDocaccepts { get; set; }

    public virtual DbSet<EdoResign> EdoResigns { get; set; }

    public virtual DbSet<EdoTopic> EdoTopics { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAddr> EmployeeAddrs { get; set; }

    public virtual DbSet<EmployeeCont> EmployeeConts { get; set; }

    public virtual DbSet<EmployeeRegister> EmployeeRegisters { get; set; }

    public virtual DbSet<EmployeeRegisterQ> EmployeeRegisterQs { get; set; }

    public virtual DbSet<EmployeeSelfupdate> EmployeeSelfupdates { get; set; }

    public virtual DbSet<Eventtype> Eventtypes { get; set; }

    public virtual DbSet<HrPdpa> HrPdpas { get; set; }

    public virtual DbSet<HrPdpaPermiss> HrPdpaPermisses { get; set; }

    public virtual DbSet<HrRecruit0> HrRecruit0s { get; set; }

    public virtual DbSet<HrRecruit0Interview> HrRecruit0Interviews { get; set; }

    public virtual DbSet<HrRecruit1> HrRecruit1s { get; set; }

    public virtual DbSet<HrRecruit2> HrRecruit2s { get; set; }

    public virtual DbSet<HrRecruit3Child> HrRecruit3Children { get; set; }

    public virtual DbSet<HrRecruit4Fam> HrRecruit4Fams { get; set; }

    public virtual DbSet<HrRecruit5Addr> HrRecruit5Addrs { get; set; }

    public virtual DbSet<HrRecruit6Work> HrRecruit6Works { get; set; }

    public virtual DbSet<HrRecruit7Edu> HrRecruit7Edus { get; set; }

    public virtual DbSet<HrRecruit8Skill> HrRecruit8Skills { get; set; }

    public virtual DbSet<HrRecruit9Ref> HrRecruit9Refs { get; set; }

    public virtual DbSet<HrRecruitOther> HrRecruitOthers { get; set; }

    public virtual DbSet<HrRecruitVaccine> HrRecruitVaccines { get; set; }

    public virtual DbSet<HrRecruitVaccinestt> HrRecruitVaccinestts { get; set; }

    public virtual DbSet<HrResource> HrResources { get; set; }

    public virtual DbSet<IntDocform> IntDocforms { get; set; }

    public virtual DbSet<IntDocrunning> IntDocrunnings { get; set; }

    public virtual DbSet<IntMeetroom> IntMeetrooms { get; set; }

    public virtual DbSet<IvtStatus> IvtStatuses { get; set; }

    public virtual DbSet<JirReport> JirReports { get; set; }

    public virtual DbSet<JobPosition> JobPositions { get; set; }

    public virtual DbSet<JqzAn> JqzAns { get; set; }

    public virtual DbSet<JqzAnsuser> JqzAnsusers { get; set; }

    public virtual DbSet<JqzAnsval> JqzAnsvals { get; set; }

    public virtual DbSet<JqzQuest> JqzQuests { get; set; }

    public virtual DbSet<JqzQuiz> JqzQuizzes { get; set; }

    public virtual DbSet<JsaAccesslog> JsaAccesslogs { get; set; }

    public virtual DbSet<JsaAccesstoken> JsaAccesstokens { get; set; }

    public virtual DbSet<JsaActionlog> JsaActionlogs { get; set; }

    public virtual DbSet<JsaAuthenid> JsaAuthenids { get; set; }

    public virtual DbSet<Leavetype> Leavetypes { get; set; }

    public virtual DbSet<MasCrmcalltime> MasCrmcalltimes { get; set; }

    public virtual DbSet<MasThpDistrict> MasThpDistricts { get; set; }

    public virtual DbSet<MasThpGeography> MasThpGeographies { get; set; }

    public virtual DbSet<MasThpProvince> MasThpProvinces { get; set; }

    public virtual DbSet<MasThpSubdistrict> MasThpSubdistricts { get; set; }

    public virtual DbSet<MasThpZipcode> MasThpZipcodes { get; set; }

    public virtual DbSet<MasVaccine> MasVaccines { get; set; }

    public virtual DbSet<MdlSpOfftakeAreaYearSum> MdlSpOfftakeAreaYearSums { get; set; }

    public virtual DbSet<MdlSpOfftakeChartAccMonth> MdlSpOfftakeChartAccMonths { get; set; }

    public virtual DbSet<MdlSpOfftakeChartAreaMonth> MdlSpOfftakeChartAreaMonths { get; set; }

    public virtual DbSet<MdlSpOfftakeD2dstaffSale> MdlSpOfftakeD2dstaffSales { get; set; }

    public virtual DbSet<MdlSpOfftakeProductMonthly> MdlSpOfftakeProductMonthlies { get; set; }

    public virtual DbSet<MdlSpOfftakeProductSkumonthly> MdlSpOfftakeProductSkumonthlies { get; set; }

    public virtual DbSet<MdlSpOfftakeStaffSale> MdlSpOfftakeStaffSales { get; set; }

    public virtual DbSet<MdlSpOfftakeStoreSale> MdlSpOfftakeStoreSales { get; set; }

    public virtual DbSet<MdlSpOfftakeStoreSumm> MdlSpOfftakeStoreSumms { get; set; }

    public virtual DbSet<MdlSpOfftakeSupSale> MdlSpOfftakeSupSales { get; set; }

    public virtual DbSet<MdlSpOfftakeSupSelfSale> MdlSpOfftakeSupSelfSales { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Newsfeed> Newsfeeds { get; set; }

    public virtual DbSet<OnlineRegisted> OnlineRegisteds { get; set; }

    public virtual DbSet<OnlineRegistration> OnlineRegistrations { get; set; }

    public virtual DbSet<Oo> Oos { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductPricerate> ProductPricerates { get; set; }

    public virtual DbSet<Productpricetype> Productpricetypes { get; set; }

    public virtual DbSet<Productsku> Productskus { get; set; }

    public virtual DbSet<ProductskuPricesurvey> ProductskuPricesurveys { get; set; }

    public virtual DbSet<ProductskuSo> ProductskuSos { get; set; }

    public virtual DbSet<Producttype> Producttypes { get; set; }

    public virtual DbSet<QuaSlip> QuaSlips { get; set; }

    public virtual DbSet<RecMinaddr> RecMinaddrs { get; set; }

    public virtual DbSet<RecMineducat> RecMineducats { get; set; }

    public virtual DbSet<RecMinexper> RecMinexpers { get; set; }

    public virtual DbSet<RecMinhistory> RecMinhistories { get; set; }

    public virtual DbSet<RecMinskill> RecMinskills { get; set; }

    public virtual DbSet<RecMinskilllang> RecMinskilllangs { get; set; }

    public virtual DbSet<Receipt> Receipts { get; set; }

    public virtual DbSet<ReceiptCanceled> ReceiptCanceleds { get; set; }

    public virtual DbSet<ReceiptH> ReceiptHs { get; set; }

    public virtual DbSet<ReceiptTotal> ReceiptTotals { get; set; }

    public virtual DbSet<RunReceipt> RunReceipts { get; set; }

    public virtual DbSet<RunStockcard> RunStockcards { get; set; }

    public virtual DbSet<SalaryslipDdatum> SalaryslipDdata { get; set; }

    public virtual DbSet<SalaryslipDtl> SalaryslipDtls { get; set; }

    public virtual DbSet<SalaryslipFoot> SalaryslipFeet { get; set; }

    public virtual DbSet<SalaryslipHdatum> SalaryslipHdata { get; set; }

    public virtual DbSet<SalaryslipHead> SalaryslipHeads { get; set; }

    public virtual DbSet<SosShelftype> SosShelftypes { get; set; }

    public virtual DbSet<StfAvatar> StfAvatars { get; set; }

    public virtual DbSet<StfCompany> StfCompanies { get; set; }

    public virtual DbSet<StfRegsecure> StfRegsecures { get; set; }

    public virtual DbSet<StfSecureActive> StfSecureActives { get; set; }

    public virtual DbSet<StfSign> StfSigns { get; set; }

    public virtual DbSet<StfSignLog> StfSignLogs { get; set; }

    public virtual DbSet<StfSignature> StfSignatures { get; set; }

    public virtual DbSet<StfTeam> StfTeams { get; set; }

    public virtual DbSet<StfTeamcap> StfTeamcaps { get; set; }

    public virtual DbSet<StfTeammenu> StfTeammenus { get; set; }

    public virtual DbSet<StfUatuser> StfUatusers { get; set; }

    public virtual DbSet<StfUsergroup> StfUsergroups { get; set; }

    public virtual DbSet<StfUsergroupsLine> StfUsergroupsLines { get; set; }

    public virtual DbSet<StfUsertoken> StfUsertokens { get; set; }

    public virtual DbSet<Stockin> Stockins { get; set; }

    public virtual DbSet<Stockout> Stockouts { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreLocation> StoreLocations { get; set; }

    public virtual DbSet<StoreTarget> StoreTargets { get; set; }

    public virtual DbSet<StoreTargetProduct> StoreTargetProducts { get; set; }

    public virtual DbSet<Storegroup> Storegroups { get; set; }

    public virtual DbSet<Storestaff> Storestaffs { get; set; }

    public virtual DbSet<Storetype> Storetypes { get; set; }

    public virtual DbSet<SysAccessLog> SysAccessLogs { get; set; }

    public virtual DbSet<SysAppupdate> SysAppupdates { get; set; }

    public virtual DbSet<SysDevice> SysDevices { get; set; }

    public virtual DbSet<SysDeviceAtt> SysDeviceAtts { get; set; }

    public virtual DbSet<SysEmailsentLog> SysEmailsentLogs { get; set; }

    public virtual DbSet<SysExceptionLog> SysExceptionLogs { get; set; }

    public virtual DbSet<SysFuncsett> SysFuncsetts { get; set; }

    public virtual DbSet<SysLogapi> SysLogapis { get; set; }

    public virtual DbSet<SysMenu> SysMenus { get; set; }

    public virtual DbSet<SysMobileexceptionLog> SysMobileexceptionLogs { get; set; }

    public virtual DbSet<SysMobileset> SysMobilesets { get; set; }

    public virtual DbSet<SysNotify> SysNotifies { get; set; }

    public virtual DbSet<SysNotifyMessage> SysNotifyMessages { get; set; }

    public virtual DbSet<SysNotifyTime> SysNotifyTimes { get; set; }

    public virtual DbSet<SysNotifyTime2> SysNotifyTime2s { get; set; }

    public virtual DbSet<SysOtpBydevice> SysOtpBydevices { get; set; }

    public virtual DbSet<SysPermission> SysPermissions { get; set; }

    public virtual DbSet<SysRealtimelocation> SysRealtimelocations { get; set; }

    public virtual DbSet<SysSmsotphi> SysSmsotphis { get; set; }

    public virtual DbSet<SysSmssent> SysSmssents { get; set; }

    public virtual DbSet<SysWinappregister> SysWinappregisters { get; set; }

    public virtual DbSet<TestPermit> TestPermits { get; set; }

    public virtual DbSet<Titlename> Titlenames { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<ViewAreastaff> ViewAreastaffs { get; set; }

    public virtual DbSet<ViewAtt> ViewAtts { get; set; }

    public virtual DbSet<ViewAttcheckinDay> ViewAttcheckinDays { get; set; }

    public virtual DbSet<ViewAttendancesumm> ViewAttendancesumms { get; set; }

    public virtual DbSet<ViewAttgoanywhere> ViewAttgoanywheres { get; set; }

    public virtual DbSet<ViewAttleave4> ViewAttleave4s { get; set; }

    public virtual DbSet<ViewAttmonth> ViewAttmonths { get; set; }

    public virtual DbSet<ViewAttmonthIo> ViewAttmonthIos { get; set; }

    public virtual DbSet<ViewAttweekendhol> ViewAttweekendhols { get; set; }

    public virtual DbSet<ViewBrand> ViewBrands { get; set; }

    public virtual DbSet<ViewCnndatum> ViewCnndata { get; set; }

    public virtual DbSet<ViewComgroupmember> ViewComgroupmembers { get; set; }

    public virtual DbSet<ViewCpnprodtarget> ViewCpnprodtargets { get; set; }

    public virtual DbSet<ViewCpnprodtargetDatum> ViewCpnprodtargetData { get; set; }

    public virtual DbSet<ViewCrm> ViewCrms { get; set; }

    public virtual DbSet<ViewCrmcontactTel> ViewCrmcontactTels { get; set; }

    public virtual DbSet<ViewCrmproductFback> ViewCrmproductFbacks { get; set; }

    public virtual DbSet<ViewCrmregi> ViewCrmregis { get; set; }

    public virtual DbSet<ViewCrmstore> ViewCrmstores { get; set; }

    public virtual DbSet<ViewCrmtel> ViewCrmtels { get; set; }

    public virtual DbSet<ViewDeviceinfo> ViewDeviceinfos { get; set; }

    public virtual DbSet<ViewDeviceinfo2> ViewDeviceinfo2s { get; set; }

    public virtual DbSet<ViewDeviceinfostati> ViewDeviceinfostatis { get; set; }

    public virtual DbSet<ViewDeviceuserIsupdate> ViewDeviceuserIsupdates { get; set; }

    public virtual DbSet<ViewDeviceuserNotupdate> ViewDeviceuserNotupdates { get; set; }

    public virtual DbSet<ViewDeviceuserlastupdate> ViewDeviceuserlastupdates { get; set; }

    public virtual DbSet<ViewEdoDocaccept> ViewEdoDocaccepts { get; set; }

    public virtual DbSet<ViewEdoDocaccept2> ViewEdoDocaccept2s { get; set; }

    public virtual DbSet<ViewEmployee> ViewEmployees { get; set; }

    public virtual DbSet<ViewEmployee2> ViewEmployee2s { get; set; }

    public virtual DbSet<ViewEmployeecont> ViewEmployeeconts { get; set; }

    public virtual DbSet<ViewGroupline> ViewGrouplines { get; set; }

    public virtual DbSet<ViewHrrecruitAddr> ViewHrrecruitAddrs { get; set; }

    public virtual DbSet<ViewJqan> ViewJqans { get; set; }

    public virtual DbSet<ViewJqzan> ViewJqzans { get; set; }

    public virtual DbSet<ViewJqzansuser> ViewJqzansusers { get; set; }

    public virtual DbSet<ViewJqzquest> ViewJqzquests { get; set; }

    public virtual DbSet<ViewJsaacclog> ViewJsaacclogs { get; set; }

    public virtual DbSet<ViewMReceiptstoresku> ViewMReceiptstoreskus { get; set; }

    public virtual DbSet<ViewMobilelog> ViewMobilelogs { get; set; }

    public virtual DbSet<ViewMobilelogErrorCrm> ViewMobilelogErrorCrms { get; set; }

    public virtual DbSet<ViewNewstockBal> ViewNewstockBals { get; set; }

    public virtual DbSet<ViewOft> ViewOfts { get; set; }

    public virtual DbSet<ViewOftAccSmonth> ViewOftAccSmonths { get; set; }

    public virtual DbSet<ViewOftAccSmonth2> ViewOftAccSmonth2s { get; set; }

    public virtual DbSet<ViewOftDay> ViewOftDays { get; set; }

    public virtual DbSet<ViewOftProdSmonth> ViewOftProdSmonths { get; set; }

    public virtual DbSet<ViewOftProdSmonth2> ViewOftProdSmonth2s { get; set; }

    public virtual DbSet<ViewOftProdSmonthx> ViewOftProdSmonthxes { get; set; }

    public virtual DbSet<ViewOftSkuD2d> ViewOftSkuD2ds { get; set; }

    public virtual DbSet<ViewOftSkuD2dx> ViewOftSkuD2dxes { get; set; }

    public virtual DbSet<ViewOftStaff> ViewOftStaffs { get; set; }

    public virtual DbSet<ViewOftStaffSmonth> ViewOftStaffSmonths { get; set; }

    public virtual DbSet<ViewOftStaffx> ViewOftStaffxes { get; set; }

    public virtual DbSet<ViewOftStoreSmonth> ViewOftStoreSmonths { get; set; }

    public virtual DbSet<ViewOftSupSmonth> ViewOftSupSmonths { get; set; }

    public virtual DbSet<ViewOo> ViewOos { get; set; }

    public virtual DbSet<ViewOos2> ViewOos2s { get; set; }

    public virtual DbSet<ViewPermission> ViewPermissions { get; set; }

    public virtual DbSet<ViewProduct> ViewProducts { get; set; }

    public virtual DbSet<ViewProductCompet> ViewProductCompets { get; set; }

    public virtual DbSet<ViewProductsSku> ViewProductsSkus { get; set; }

    public virtual DbSet<ViewProductskuBal> ViewProductskuBals { get; set; }

    public virtual DbSet<ViewRawOfftakeEuc> ViewRawOfftakeEucs { get; set; }

    public virtual DbSet<ViewRealtimelocation> ViewRealtimelocations { get; set; }

    public virtual DbSet<ViewReceiptStaff> ViewReceiptStaffs { get; set; }

    public virtual DbSet<ViewReceiptSumout> ViewReceiptSumouts { get; set; }

    public virtual DbSet<ViewReceiptlist> ViewReceiptlists { get; set; }

    public virtual DbSet<ViewReceiptprod> ViewReceiptprods { get; set; }

    public virtual DbSet<ViewReceptUserpcount> ViewReceptUserpcounts { get; set; }

    public virtual DbSet<ViewRecruit0> ViewRecruit0s { get; set; }

    public virtual DbSet<ViewSalary> ViewSalaries { get; set; }

    public virtual DbSet<ViewSalaryhi> ViewSalaryhis { get; set; }

    public virtual DbSet<ViewSaleout> ViewSaleouts { get; set; }

    public virtual DbSet<ViewSkupricesurvey> ViewSkupricesurveys { get; set; }

    public virtual DbSet<ViewStaffSup> ViewStaffSups { get; set; }

    public virtual DbSet<ViewStaffarea> ViewStaffareas { get; set; }

    public virtual DbSet<ViewStfactive> ViewStfactives { get; set; }

    public virtual DbSet<ViewStfhilev> ViewStfhilevs { get; set; }

    public virtual DbSet<ViewStfusergroupline> ViewStfusergrouplines { get; set; }

    public virtual DbSet<ViewStockbal> ViewStockbals { get; set; }

    public virtual DbSet<ViewStockbalDtl> ViewStockbalDtls { get; set; }

    public virtual DbSet<ViewStockcard> ViewStockcards { get; set; }

    public virtual DbSet<ViewStockin> ViewStockins { get; set; }

    public virtual DbSet<ViewStockout> ViewStockouts { get; set; }

    public virtual DbSet<ViewStorelocation> ViewStorelocations { get; set; }

    public virtual DbSet<ViewStorerecept> ViewStorerecepts { get; set; }

    public virtual DbSet<ViewStorestaff> ViewStorestaffs { get; set; }

    public virtual DbSet<ViewStorestafflocation> ViewStorestafflocations { get; set; }

    public virtual DbSet<ViewSyscrmSummary> ViewSyscrmSummaries { get; set; }

    public virtual DbSet<ViewSyscrmUsersumm> ViewSyscrmUsersumms { get; set; }

    public virtual DbSet<ViewSysdeviceatt> ViewSysdeviceatts { get; set; }

    public virtual DbSet<ViewTeammenu> ViewTeammenus { get; set; }

    public virtual DbSet<ViewTeamsku> ViewTeamskus { get; set; }

    public virtual DbSet<ViewThaicounty> ViewThaicounties { get; set; }

    public virtual DbSet<ViewWinappregister> ViewWinappregisters { get; set; }

    public virtual DbSet<WebcMenu> WebcMenus { get; set; }

    public virtual DbSet<WebcMenusPermiss> WebcMenusPermisses { get; set; }

    public virtual DbSet<WebcReportexp> WebcReportexps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=103.76.180.20;Initial Catalog=JMMDATACENTER;User ID=sa;Password=sqlampwd@2020;Encrypt=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AREA__3214EC279C6F4223");

            entity.ToTable("AREA");

            entity.HasIndex(e => e.Areacode, "AREA_AREACODE");

            entity.HasIndex(e => e.Areaname, "AREA_AREANAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Arearegion>(entity =>
        {
            entity.ToTable("AREAREGION");

            entity.HasIndex(e => e.Stt, "IX_AREAREGION_STT");

            entity.HasIndex(e => e.Teamid, "IX_AREAREGION_TEAMID");

            entity.HasIndex(e => e.Stt, "STT");

            entity.HasIndex(e => e.Teamid, "TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Areaids)
                .HasColumnType("text")
                .HasColumnName("AREAIDS");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Regname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REGNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ArearegionStaff>(entity =>
        {
            entity.ToTable("AREAREGION_STAFF");

            entity.HasIndex(e => e.Id, "IX_AREAREGION_STAFF_STAFFID");

            entity.HasIndex(e => e.Id, "IX_AREAREGION_STAFF_STT");

            entity.HasIndex(e => e.Staffid, "STAFFID");

            entity.HasIndex(e => e.Stt, "STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Regionid).HasColumnName("REGIONID");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Areastaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AREASTAF__3214EC27EA9786AA");

            entity.ToTable("AREASTAFF");

            entity.HasIndex(e => e.Areaid, "AREASTAFF_AREAID");

            entity.HasIndex(e => e.Staffid, "AREASTAFF_STAFFID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTENDAN__3214EC27C7460C3B");

            entity.ToTable("ATTENDANCE");

            entity.HasIndex(e => e.Stamptype, "ATTENDANCE_STAMPTYPE");

            entity.HasIndex(e => e.Storeid, "ATTENDANCE_STOREID");

            entity.HasIndex(e => e.Userid, "ATTENDANCE_USERID");

            entity.HasIndex(e => e.Stt, "DEPTCODE_STT");

            entity.HasIndex(e => e.Leavetype, "IX_ATTENDANCE_LEAVETYPE");

            entity.HasIndex(e => e.Stamp, "IX_ATTENDANCE_STAMP");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CheckinGps)
                .HasMaxLength(100)
                .HasColumnName("CHECKIN_GPS");
            entity.Property(e => e.Checkinname)
                .HasMaxLength(100)
                .HasColumnName("CHECKINNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Leavetype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEAVETYPE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("REASON");
            entity.Property(e => e.Stamp)
                .HasColumnType("datetime")
                .HasColumnName("STAMP");
            entity.Property(e => e.Stamptype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STAMPTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Attgoanywhere>(entity =>
        {
            entity.ToTable("ATTGOANYWHERE");

            entity.HasIndex(e => e.Attime, "ATTIME");

            entity.HasIndex(e => e.Empid, "EMPID");

            entity.HasIndex(e => e.Eventtypeid, "EVENTTYPEID");

            entity.HasIndex(e => e.Attime, "IX_ATTGOANYWHERE_ATTIME");

            entity.HasIndex(e => e.Empid, "IX_ATTGOANYWHERE_EMPID");

            entity.HasIndex(e => e.Eventtypeid, "IX_ATTGOANYWHERE_EVENTTYPEID");

            entity.HasIndex(e => e.Stt, "STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Atplace)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATPLACE");
            entity.Property(e => e.Attime)
                .HasColumnType("datetime")
                .HasColumnName("ATTIME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Eventname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EVENTNAME");
            entity.Property(e => e.Eventtypeid).HasColumnName("EVENTTYPEID");
            entity.Property(e => e.Gps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPS");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Attleave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTLEAVE__3214EC27EAD1A2E6");

            entity.ToTable("ATTLEAVE");

            entity.HasIndex(e => e.Leavetype, "ATTLEAVE_LEAVETYPE");

            entity.HasIndex(e => e.Storeid, "ATTLEAVE_STOREID");

            entity.HasIndex(e => e.Stt, "ATTLEAVE_STT");

            entity.HasIndex(e => e.Userid, "ATTLEAVE_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Endleave)
                .HasColumnType("datetime")
                .HasColumnName("ENDLEAVE");
            entity.Property(e => e.Imgnames)
                .HasMaxLength(300)
                .HasColumnName("IMGNAMES");
            entity.Property(e => e.Leavedays).HasColumnName("LEAVEDAYS");
            entity.Property(e => e.Leavehours).HasColumnName("LEAVEHOURS");
            entity.Property(e => e.Leavetype).HasColumnName("LEAVETYPE");
            entity.Property(e => e.Reason)
                .HasMaxLength(300)
                .HasColumnName("REASON");
            entity.Property(e => e.Startleave)
                .HasColumnType("datetime")
                .HasColumnName("STARTLEAVE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<AttleaveApv>(entity =>
        {
            entity.ToTable("ATTLEAVE_APV");

            entity.HasIndex(e => e.Leaveid, "IX_ATTLEAVE_APV_LEAVEID");

            entity.HasIndex(e => e.Stt, "IX_ATTLEAVE_APV_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apv1date)
                .HasColumnType("datetime")
                .HasColumnName("APV1DATE");
            entity.Property(e => e.Apv1stt).HasColumnName("APV1STT");
            entity.Property(e => e.Apv2date)
                .HasColumnType("datetime")
                .HasColumnName("APV2DATE");
            entity.Property(e => e.Apv2stt).HasColumnName("APV2STT");
            entity.Property(e => e.Apv3date)
                .HasColumnType("datetime")
                .HasColumnName("APV3DATE");
            entity.Property(e => e.Apv3stt).HasColumnName("APV3STT");
            entity.Property(e => e.Apvid1).HasColumnName("APVID1");
            entity.Property(e => e.Apvid2).HasColumnName("APVID2");
            entity.Property(e => e.Apvid3).HasColumnName("APVID3");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Leaveid).HasColumnName("LEAVEID");
            entity.Property(e => e.Remark1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMARK1");
            entity.Property(e => e.Remark2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMARK2");
            entity.Property(e => e.Remark3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMARK3");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<AttleaveImg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTLEAVE__3214EC27BCDDC024");

            entity.ToTable("ATTLEAVE_IMG");

            entity.HasIndex(e => e.Stt, "ATTLEAVE_IMG_STT");

            entity.HasIndex(e => e.Userid, "ATTLEAVE_IMG_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.ImgBase64)
                .HasColumnType("text")
                .HasColumnName("IMG_BASE64");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Attweekend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTWEEKE__3214EC275CF3B052");

            entity.ToTable("ATTWEEKEND");

            entity.HasIndex(e => e.Storeid, "ATTWEEKEND_STOREID");

            entity.HasIndex(e => e.Stt, "ATTWEEKEND_STT");

            entity.HasIndex(e => e.Userid, "ATTWEEKEND_USERID");

            entity.HasIndex(e => e.Id, "IX_ATTWEEKEND");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Htype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HTYPE");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BRAND__3214EC27D8928166");

            entity.ToTable("BRAND");

            entity.HasIndex(e => e.Brandcode, "BRAND_BRANDCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<BrandSub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BRAND_SU__3214EC27A444FAF9");

            entity.ToTable("BRAND_SUB");

            entity.HasIndex(e => e.SubbrandCode, "BRAND_SUB_SUBBRAND_CODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Brandid).HasColumnName("BRANDID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.SubbrandCode)
                .HasMaxLength(250)
                .HasColumnName("SUBBRAND_CODE");
            entity.Property(e => e.SubbrandName)
                .HasMaxLength(250)
                .HasColumnName("SUBBRAND_NAME");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Cnndatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CNNDATA__3214EC2738B90591");

            entity.ToTable("CNNDATA");

            entity.HasIndex(e => e.Atdate, "CNNDATA_ATDATE");

            entity.HasIndex(e => e.Id, "CNNDATA_ID");

            entity.HasIndex(e => e.Skuid, "CNNDATA_SKUID");

            entity.HasIndex(e => e.Storeid, "CNNDATA_STOREID");

            entity.HasIndex(e => e.Stt, "CNNDATA_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cnnstatus)
                .HasMaxLength(3)
                .HasColumnName("CNNSTATUS");
            entity.Property(e => e.Cnntype)
                .HasMaxLength(3)
                .HasColumnName("CNNTYPE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skucode)
                .HasMaxLength(150)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ComGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COM_GROU__3214EC27EC7DB79E");

            entity.ToTable("COM_GROUP");

            entity.HasIndex(e => e.Groupid, "COM_GROUP_GROUPID");

            entity.HasIndex(e => e.Groupname, "COM_GROUP_GROUPNAME");

            entity.HasIndex(e => e.Id, "COM_GROUP_ID");

            entity.HasIndex(e => e.Stt, "COM_GROUP_STT");

            entity.HasIndex(e => e.Grouptype, "CPNDATA_GROUPTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Groupdesc)
                .HasMaxLength(255)
                .HasColumnName("GROUPDESC");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Groupkey)
                .HasMaxLength(255)
                .HasColumnName("GROUPKEY");
            entity.Property(e => e.Groupname)
                .HasMaxLength(255)
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.Grouptype)
                .HasMaxLength(10)
                .HasColumnName("GROUPTYPE");
            entity.Property(e => e.Ispublic).HasColumnName("ISPUBLIC");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ComGroupmember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COM_GROU__3214EC27E978C342");

            entity.ToTable("COM_GROUPMEMBER");

            entity.HasIndex(e => e.Groupid, "COM_GROUPMEMBER_GROUPID");

            entity.HasIndex(e => e.Id, "COM_GROUPMEMBER_ID");

            entity.HasIndex(e => e.Stt, "COM_GROUPMEMBER_STT");

            entity.HasIndex(e => e.Userid, "COM_GROUPMEMBER_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Groupkey)
                .HasMaxLength(255)
                .HasColumnName("GROUPKEY");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userdisplay)
                .HasMaxLength(255)
                .HasColumnName("USERDISPLAY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Cpndatamaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CPNDATAM__3214EC27AA897EF4");

            entity.ToTable("CPNDATAMASTER");

            entity.HasIndex(e => e.Id, "CPNDATAMASTER_ID");

            entity.HasIndex(e => e.Stt, "CPNDATAMASTER_STT");

            entity.HasIndex(e => e.Teamid, "CPNDATAMASTER_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cpnid).HasColumnName("CPNID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Producttypeid).HasColumnName("PRODUCTTYPEID");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("VALUE");
            entity.Property(e => e.Valueposi)
                .HasMaxLength(3)
                .HasColumnName("VALUEPOSI");
            entity.Property(e => e.Valuetype)
                .HasMaxLength(3)
                .HasColumnName("VALUETYPE");
        });

        modelBuilder.Entity<Cpndatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CPNDATA__3214EC2790FA1528");

            entity.ToTable("CPNDATA");

            entity.HasIndex(e => e.Atdate, "CPNDATA_ATDATE");

            entity.HasIndex(e => e.Id, "CPNDATA_ID");

            entity.HasIndex(e => e.Masterid, "CPNDATA_MASTERID");

            entity.HasIndex(e => e.Stt, "CPNDATA_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Masterid).HasColumnName("MASTERID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Cpnprodtarget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CPNPRODT__3214EC27C5C1E5E4");

            entity.ToTable("CPNPRODTARGET");

            entity.HasIndex(e => e.Atdate, "CPNPRODTARGET_ATDATE");

            entity.HasIndex(e => e.Cpnid, "CPNPRODTARGET_CPNID");

            entity.HasIndex(e => e.Id, "CPNPRODTARGET_ID");

            entity.HasIndex(e => e.Priority, "CPNPRODTARGET_PRIORITY");

            entity.HasIndex(e => e.Stt, "CPNPRODTARGET_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cpnid).HasColumnName("CPNID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Display)
                .HasMaxLength(200)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<CpnprodtargetDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CPNPRODT__3214EC27919ED651");

            entity.ToTable("CPNPRODTARGET_DATA");

            entity.HasIndex(e => e.Atdate, "CPNPRODTARGET_DATA_ATDATE");

            entity.HasIndex(e => e.Cpntype, "CPNPRODTARGET_DATA_CPNTYPE");

            entity.HasIndex(e => e.Id, "CPNPRODTARGET_DATA_ID");

            entity.HasIndex(e => e.Prodtargetid, "CPNPRODTARGET_DATA_PRODTARGETID");

            entity.HasIndex(e => e.Storeid, "CPNPRODTARGET_DATA_STOREID");

            entity.HasIndex(e => e.Stt, "CPNPRODTARGET_DATA_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cpncount).HasColumnName("CPNCOUNT");
            entity.Property(e => e.Cpntype)
                .HasMaxLength(3)
                .HasColumnName("CPNTYPE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Photoname)
                .HasMaxLength(50)
                .HasColumnName("PHOTONAME");
            entity.Property(e => e.Prodtargetid).HasColumnName("PRODTARGETID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tghilight).HasColumnName("TGHILIGHT");
            entity.Property(e => e.Tgstatus).HasColumnName("TGSTATUS");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Cpnstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CPNSTATU__3214EC27332FF5B5");

            entity.ToTable("CPNSTATUS");

            entity.HasIndex(e => e.Code, "CPNSTATUS_CODE");

            entity.HasIndex(e => e.Id, "CPNSTATUS_ID");

            entity.HasIndex(e => e.Stt, "CPNSTATUS_STT");

            entity.HasIndex(e => e.Teamid, "CPNSTATUS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("CODE");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<Crmaddr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRMADDR__3214EC27E4B0334C");

            entity.ToTable("CRMADDR");

            entity.HasIndex(e => e.Customerid, "CRMADDR_CUSTOMERID");

            entity.HasIndex(e => e.Stt, "CRMADDR_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Building)
                .HasMaxLength(200)
                .HasColumnName("BUILDING");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(20)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(50)
                .HasColumnName("HOUSE_NO");
            entity.Property(e => e.Moo)
                .HasMaxLength(50)
                .HasColumnName("MOO");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(20)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.Road)
                .HasMaxLength(200)
                .HasColumnName("ROAD");
            entity.Property(e => e.Soi)
                .HasMaxLength(200)
                .HasColumnName("SOI");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(20)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<Crmcontact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRMCONTA__3214EC27535A0415");

            entity.ToTable("CRMCONTACT");

            entity.HasIndex(e => e.Customerid, "CRMCONTACT_CUSTOMERID");

            entity.HasIndex(e => e.Stt, "CRMCONTACT_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fb)
                .HasMaxLength(100)
                .HasColumnName("FB");
            entity.Property(e => e.Ig)
                .HasMaxLength(100)
                .HasColumnName("IG");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("TEL");
            entity.Property(e => e.Twit)
                .HasMaxLength(100)
                .HasColumnName("TWIT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<CrmproductFback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRMPRODU__3214EC27C53A492E");

            entity.ToTable("CRMPRODUCT_FBACK");

            entity.HasIndex(e => e.Customerid, "CRMPRODUCT_FBACK_CUSTOMERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
            entity.Property(e => e.ProductOth)
                .HasMaxLength(250)
                .HasColumnName("PRODUCT_OTH");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("REMARK");
        });

        modelBuilder.Entity<Crmregi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRMREGIS__3214EC27AEAA1522");

            entity.ToTable("CRMREGIS");

            entity.HasIndex(e => e.CustomerCode, "CRMREGIS_CUSTOMER_CODE");

            entity.HasIndex(e => e.Firstname, "CRMREGIS_FIRSTNAME");

            entity.HasIndex(e => e.Id, "CRMREGIS_ID");

            entity.HasIndex(e => e.Storeid, "CRMREGIS_STOREID");

            entity.HasIndex(e => e.Stt, "CRMREGIS_STT");

            entity.HasIndex(e => e.Teamid, "CRMREGIS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Contdays)
                .HasMaxLength(100)
                .HasColumnName("CONTDAYS");
            entity.Property(e => e.Conttime).HasColumnName("CONTTIME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.GetProductFrom)
                .HasMaxLength(250)
                .HasColumnName("GET_PRODUCT_FROM");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Maternity)
                .HasColumnType("datetime")
                .HasColumnName("MATERNITY");
            entity.Property(e => e.RefBirthdate)
                .HasColumnType("datetime")
                .HasColumnName("REF_BIRTHDATE");
            entity.Property(e => e.RefFirstname)
                .HasMaxLength(100)
                .HasColumnName("REF_FIRSTNAME");
            entity.Property(e => e.RefLastname)
                .HasMaxLength(100)
                .HasColumnName("REF_LASTNAME");
            entity.Property(e => e.RefMage).HasColumnName("REF_MAGE");
            entity.Property(e => e.RefYage).HasColumnName("REF_YAGE");
            entity.Property(e => e.Regisdate)
                .HasColumnType("datetime")
                .HasColumnName("REGISDATE");
            entity.Property(e => e.Regisgroup)
                .HasMaxLength(3)
                .HasColumnName("REGISGROUP");
            entity.Property(e => e.Relation).HasColumnName("RELATION");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Crmsegment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRMSEGME__3214EC2700897A85");

            entity.ToTable("CRMSEGMENT");

            entity.HasIndex(e => e.Segcode, "CRMSEGMENT_SEGCODE");

            entity.HasIndex(e => e.Stt, "CRMSEGMENT_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Segcode)
                .HasMaxLength(50)
                .HasColumnName("SEGCODE");
            entity.Property(e => e.Segname)
                .HasMaxLength(250)
                .HasColumnName("SEGNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Team).HasColumnName("TEAM");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Definedatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DEFINEDA__3214EC2736C5DFA4");

            entity.ToTable("DEFINEDATA");

            entity.HasIndex(e => e.Code, "DEFINEDATA_CODE");

            entity.HasIndex(e => e.Id, "DEFINEDATA_ID");

            entity.HasIndex(e => e.Syscode, "DEFINEDATA_SYSCODE");

            entity.HasIndex(e => e.Teamid, "DEFINEDATA_TEAMID");

            entity.HasIndex(e => e.Typecode, "DEFINEDATA_TYPECODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("CODE");
            entity.Property(e => e.Descript)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Syscode)
                .HasMaxLength(20)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Tag)
                .HasColumnType("ntext")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Typecode)
                .HasMaxLength(20)
                .HasColumnName("TYPECODE");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DEPARTME__3214EC2714113F27");

            entity.ToTable("DEPARTMENT");

            entity.HasIndex(e => e.Deptcode, "DEPARTMENT_DEPTCODE");

            entity.HasIndex(e => e.Stt, "DEPTCODE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(50)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EdoAw>(entity =>
        {
            entity.ToTable("EDO_AWS");

            entity.HasIndex(e => e.EdoId, "IX_EDO_AWS_EDO_ID");

            entity.HasIndex(e => e.Stt, "IX_EDO_AWS_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AwsIndex).HasColumnName("AWS_INDEX");
            entity.Property(e => e.AwsText)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AWS_TEXT");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.EdoId).HasColumnName("EDO_ID");
            entity.Property(e => e.Otp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("OTP");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EdoDocaccept>(entity =>
        {
            entity.ToTable("EDO_DOCACCEPT");

            entity.HasIndex(e => e.Dcode, "IX_EDO_DOCACCEPT_DCODE");

            entity.HasIndex(e => e.Empid, "IX_EDO_DOCACCEPT_EMPID");

            entity.HasIndex(e => e.Runid, "IX_EDO_DOCACCEPT_RUNID").IsUnique();

            entity.HasIndex(e => e.Stt, "IX_EDO_DOCACCEPT_STT");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Dcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCODE");
            entity.Property(e => e.Doccontent)
                .HasColumnType("text")
                .HasColumnName("DOCCONTENT");
            entity.Property(e => e.Docstt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DOCSTT");
            entity.Property(e => e.Docvalue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOCVALUE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Runid)
                .ValueGeneratedOnAdd()
                .HasColumnName("RUNID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EdoResign>(entity =>
        {
            entity.ToTable("EDO_RESIGN");

            entity.HasIndex(e => e.Apvlevel, "EDO_RESIGN_APVLEVEL");

            entity.HasIndex(e => e.Atdate, "EDO_RESIGN_ATDATE");

            entity.HasIndex(e => e.Empid, "EDO_RESIGN_EMPID");

            entity.HasIndex(e => e.Stt, "EDO_RESIGN_STT");

            entity.HasIndex(e => e.Apvlevel, "IX_EDO_RESIGN_APVLEVEL");

            entity.HasIndex(e => e.Atdate, "IX_EDO_RESIGN_ATDATE");

            entity.HasIndex(e => e.Empid, "IX_EDO_RESIGN_EMPID");

            entity.HasIndex(e => e.Stt, "IX_EDO_RESIGN_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apvlevel).HasColumnName("APVLEVEL");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Lastwork)
                .HasColumnType("datetime")
                .HasColumnName("LASTWORK");
            entity.Property(e => e.Posname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSNAME");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Startwork)
                .HasColumnType("datetime")
                .HasColumnName("STARTWORK");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EdoTopic>(entity =>
        {
            entity.ToTable("EDO_TOPIC");

            entity.HasIndex(e => e.ActiveDate, "EDO_TOPIC_ACTIVE_DATE");

            entity.HasIndex(e => e.Edoccode, "EDO_TOPIC_EDOCCODE");

            entity.HasIndex(e => e.Empid, "EDO_TOPIC_EMPID");

            entity.HasIndex(e => e.Stt, "EDO_TOPIC_STT");

            entity.HasIndex(e => e.Empid, "IX_EDO_TOPIC");

            entity.HasIndex(e => e.ActiveDate, "IX_EDO_TOPIC_ACTIVE_DATE");

            entity.HasIndex(e => e.Edoccode, "IX_EDO_TOPIC_EDOCCODE");

            entity.HasIndex(e => e.Stt, "IX_EDO_TOPIC_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Actiontype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTIONTYPE");
            entity.Property(e => e.ActiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.Aws)
                .HasColumnType("text")
                .HasColumnName("AWS");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Edoccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDOCCODE");
            entity.Property(e => e.Edocdesp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EDOCDESP");
            entity.Property(e => e.Edocname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EDOCNAME");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Positionid).HasColumnName("POSITIONID");
            entity.Property(e => e.Qst)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("QST");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC27CD062460");

            entity.ToTable("EMPLOYEE");

            entity.HasIndex(e => e.Empcode, "EMPLOYEE_EMPCODE");

            entity.HasIndex(e => e.Stt, "EMPLOYEE_STT");

            entity.HasIndex(e => e.Tel, "EMPLOYEE_TEL");

            entity.HasIndex(e => e.Active, "IX_EMPLOYEE_ACTIVE");

            entity.HasIndex(e => e.Empid, "IX_EMPLOYEE_EMPID");

            entity.HasIndex(e => e.Tel, "IX_EMPLOYEE_TEL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Idcard)
                .HasMaxLength(255)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastworkdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTWORKDATE");
            entity.Property(e => e.Positionid).HasColumnName("POSITIONID");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Startworkdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTWORKDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasColumnName("TEL");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EmployeeAddr>(entity =>
        {
            entity.ToTable("EMPLOYEE_ADDR");

            entity.HasIndex(e => e.Empid, "IX_EMPLOYEE_ADDR_EMPID");

            entity.HasIndex(e => e.Stt, "IX_EMPLOYEE_ADDR_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CurrAddr)
                .HasColumnType("text")
                .HasColumnName("CURR_ADDR");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.HomeAddr)
                .HasColumnType("text")
                .HasColumnName("HOME_ADDR");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<EmployeeCont>(entity =>
        {
            entity.ToTable("EMPLOYEE_CONT");

            entity.HasIndex(e => e.ContNo, "EMPLOYEE_CONT_CONT_NO");

            entity.HasIndex(e => e.ContTime, "EMPLOYEE_CONT_CONT_TIME");

            entity.HasIndex(e => e.Empid, "EMPLOYEE_CONT_EMPID");

            entity.HasIndex(e => e.Id, "EMPLOYEE_CONT_ID");

            entity.HasIndex(e => e.Senddate, "EMPLOYEE_CONT_SENDDATE");

            entity.HasIndex(e => e.Stt, "EMPLOYEE_CONT_STT");

            entity.HasIndex(e => e.ContNo, "IX_EMPLOYEE_CONT_CONTNO");

            entity.HasIndex(e => e.Empid, "IX_EMPLOYEE_CONT_EMPID");

            entity.HasIndex(e => e.Senddate, "IX_EMPLOYEE_CONT_SENDDATE");

            entity.HasIndex(e => e.Stt, "IX_EMPLOYEE_CONT_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ApvDate)
                .HasColumnType("datetime")
                .HasColumnName("APV_DATE");
            entity.Property(e => e.ApvOtp)
                .HasMaxLength(20)
                .HasColumnName("APV_OTP");
            entity.Property(e => e.ContAt)
                .HasMaxLength(200)
                .HasColumnName("CONT_AT");
            entity.Property(e => e.ContNo)
                .HasMaxLength(50)
                .HasColumnName("CONT_NO");
            entity.Property(e => e.ContTime)
                .HasColumnType("datetime")
                .HasColumnName("CONT_TIME");
            entity.Property(e => e.ContenDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTEN_DATE");
            entity.Property(e => e.ContractorAddr)
                .HasColumnType("text")
                .HasColumnName("CONTRACTOR_ADDR");
            entity.Property(e => e.ContractorAge).HasColumnName("CONTRACTOR_AGE");
            entity.Property(e => e.ContstDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTST_DATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.EmpFname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_FNAME");
            entity.Property(e => e.EmpLname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_LNAME");
            entity.Property(e => e.EmpTname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMP_TNAME");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Keydata)
                .HasColumnType("text")
                .HasColumnName("KEYDATA");
            entity.Property(e => e.Positionid).HasColumnName("POSITIONID");
            entity.Property(e => e.Positionname)
                .HasMaxLength(200)
                .HasColumnName("POSITIONNAME");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALARY");
            entity.Property(e => e.Senddate)
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.WorkPromonth).HasColumnName("WORK_PROMONTH");
        });

        modelBuilder.Entity<EmployeeRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC27BE2C5EFC");

            entity.ToTable("EMPLOYEE_REGISTER");

            entity.HasIndex(e => e.Activate, "EMPLOYEE_REGISTER_ACTIVATE");

            entity.HasIndex(e => e.EmailAddr, "EMPLOYEE_REGISTER_EMAIL");

            entity.HasIndex(e => e.Stt, "EMPLOYEE_REGISTER_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Activate).HasColumnName("ACTIVATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(200)
                .HasColumnName("EMAIL_ADDR");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Vqa1)
                .HasMaxLength(200)
                .HasColumnName("VQA1");
            entity.Property(e => e.Vqa2)
                .HasMaxLength(200)
                .HasColumnName("VQA2");
            entity.Property(e => e.Vqa3)
                .HasMaxLength(200)
                .HasColumnName("VQA3");
            entity.Property(e => e.Vqs1).HasColumnName("VQS1");
            entity.Property(e => e.Vqs2).HasColumnName("VQS2");
            entity.Property(e => e.Vqs3).HasColumnName("VQS3");
        });

        modelBuilder.Entity<EmployeeRegisterQ>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC27AE5FADFC");

            entity.ToTable("EMPLOYEE_REGISTER_QS");

            entity.HasIndex(e => e.Stt, "EMPLOYEE_REGISTER_QS_STT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Question)
                .HasMaxLength(200)
                .HasColumnName("QUESTION");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<EmployeeSelfupdate>(entity =>
        {
            entity.ToTable("EMPLOYEE_SELFUPDATE");

            entity.HasIndex(e => e.CreateDate, "IX_EMPLOYEE_SELFUPDATE_CREATE_DATE");

            entity.HasIndex(e => e.Empid, "IX_EMPLOYEE_SELFUPDATE_EMPID");

            entity.HasIndex(e => e.Stt, "IX_EMPLOYEE_SELFUPDATE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CurrAddr)
                .HasColumnType("text")
                .HasColumnName("CURR_ADDR");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.HomeAddr)
                .HasColumnType("text")
                .HasColumnName("HOME_ADDR");
            entity.Property(e => e.Idcard)
                .HasMaxLength(255)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("REMARK");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasColumnName("TEL");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.Validate)
                .HasColumnType("datetime")
                .HasColumnName("VALIDATE");
        });

        modelBuilder.Entity<Eventtype>(entity =>
        {
            entity.ToTable("EVENTTYPE");

            entity.HasIndex(e => e.Eventcode, "EVENTCODE");

            entity.HasIndex(e => e.Eventname, "EVENTNAME");

            entity.HasIndex(e => e.Evtype, "EVTYPE");

            entity.HasIndex(e => e.Evtype, "IX_EVENTTYPE_EVTYPE");

            entity.HasIndex(e => e.Stt, "IX_EVENTTYPE_STT");

            entity.HasIndex(e => e.Eventcode, "IX_EVENT_EVENTCODE");

            entity.HasIndex(e => e.Stt, "STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Eventcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EVENTCODE");
            entity.Property(e => e.Eventname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EVENTNAME");
            entity.Property(e => e.Evtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EVTYPE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrPdpa>(entity =>
        {
            entity.ToTable("HR_PDPA");

            entity.HasIndex(e => e.Idcard, "IX_HR_PDPA_IDCARD");

            entity.HasIndex(e => e.Stt, "IX_HR_PDPA_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AcceptDate)
                .HasColumnType("datetime")
                .HasColumnName("ACCEPT_DATE");
            entity.Property(e => e.AcceptVal)
                .HasColumnType("text")
                .HasColumnName("ACCEPT_VAL");
            entity.Property(e => e.Addr)
                .HasColumnType("text")
                .HasColumnName("ADDR");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FNAME");
            entity.Property(e => e.Idcard)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<HrPdpaPermiss>(entity =>
        {
            entity.ToTable("HR_PDPA_PERMISS");

            entity.HasIndex(e => e.AcceptVal, "IX_HR_PDPA_PERMISS_ACCEPT_VAL").IsUnique();

            entity.HasIndex(e => e.Code, "IX_HR_PDPA_PERMISS_CODE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AcceptVal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACCEPT_VAL");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Teamids)
                .HasColumnType("text")
                .HasColumnName("TEAMIDS");
        });

        modelBuilder.Entity<HrRecruit0>(entity =>
        {
            entity.ToTable("HR_RECRUIT0");

            entity.HasIndex(e => e.ActionStatus, "IX_HR_RECRUIT0_ACTION_STATUS");

            entity.HasIndex(e => e.Fname, "IX_HR_RECRUIT0_FNAME");

            entity.HasIndex(e => e.Lname, "IX_HR_RECRUIT0_LNAME");

            entity.HasIndex(e => e.Provname, "IX_HR_RECRUIT0_PROVNAME");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT0_STT");

            entity.HasIndex(e => e.Tel, "IX_HR_RECRUIT0_TEL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActionBy).HasColumnName("ACTION_BY");
            entity.Property(e => e.ActionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("W=กำลังตรวจสอบ | F = ส่งต่อหน่วยงาน | D = นัดสัมภาษณ์ | C = จำหน่ายออก")
                .HasColumnName("ACTION_STATUS");
            entity.Property(e => e.Actiondate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIONDATE");
            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.Child).HasColumnName("CHILD");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Dadage).HasColumnName("DADAGE");
            entity.Property(e => e.Dadjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DADJOB");
            entity.Property(e => e.Dadname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DADNAME");
            entity.Property(e => e.EduInst)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EDU_INST");
            entity.Property(e => e.EduLev)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EDU_LEV");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FNAME");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Idcard)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LNAME");
            entity.Property(e => e.Marage).HasColumnName("MARAGE");
            entity.Property(e => e.Marjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MARJOB");
            entity.Property(e => e.Marname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MARNAME");
            entity.Property(e => e.Momage).HasColumnName("MOMAGE");
            entity.Property(e => e.Momjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOMJOB");
            entity.Property(e => e.Momname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOMNAME");
            entity.Property(e => e.Nic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIC");
            entity.Property(e => e.Posiname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSINAME");
            entity.Property(e => e.Provname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVNAME");
            entity.Property(e => e.Readytowork)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("READYTOWORK");
            entity.Property(e => e.Refaddr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REFADDR");
            entity.Property(e => e.Refname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFNAME");
            entity.Property(e => e.Refrelat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFRELAT");
            entity.Property(e => e.Reftel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REFTEL");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Skin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SKIN");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tatoo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TATOO");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.Workname1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME1");
            entity.Property(e => e.Workname2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME2");
            entity.Property(e => e.Workname3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME3");
            entity.Property(e => e.Workname4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME4");
            entity.Property(e => e.Workreason1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKREASON1");
            entity.Property(e => e.Workreason2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKREASON2");
            entity.Property(e => e.Workreason3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKREASON3");
            entity.Property(e => e.Workreason4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKREASON4");
            entity.Property(e => e.Worktime1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME1");
            entity.Property(e => e.Worktime2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME2");
            entity.Property(e => e.Worktime3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME3");
            entity.Property(e => e.Worktime4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME4");
        });

        modelBuilder.Entity<HrRecruit0Interview>(entity =>
        {
            entity.ToTable("HR_RECRUIT0_INTERVIEW");

            entity.HasIndex(e => e.Hid, "IX_HR_RECRUIT0_INTERVIEW_HID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.InterviewDate)
                .HasColumnType("datetime")
                .HasColumnName("INTERVIEW_DATE");
            entity.Property(e => e.InterviewRemark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INTERVIEW_REMARK");
            entity.Property(e => e.InterviewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INTERVIEW_STATUS");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HR_RECRUIT_ID");

            entity.ToTable("HR_RECRUIT1");

            entity.HasIndex(e => e.Code, "IX_HR_RECRUIT_CODE");

            entity.HasIndex(e => e.Idcard, "IX_HR_RECRUIT_IDCARD");

            entity.HasIndex(e => e.Privatecode, "IX_HR_RECRUIT_PRIVATECODE");

            entity.HasIndex(e => e.Sex, "IX_HR_RECRUIT_SEX");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.Birthplace)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BIRTHPLACE");
            entity.Property(e => e.Certexp)
                .HasColumnType("datetime")
                .HasColumnName("CERTEXP");
            entity.Property(e => e.Certno)
                .HasMaxLength(255)
                .HasColumnName("CERTNO");
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Compensation).HasColumnName("COMPENSATION");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Efname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EFNAME");
            entity.Property(e => e.Elname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ELNAME");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Enic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENIC");
            entity.Property(e => e.Etname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ETNAME");
            entity.Property(e => e.Higth).HasColumnName("HIGTH");
            entity.Property(e => e.Hosno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HOSNO");
            entity.Property(e => e.Idcard)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDCARD");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MARITAL_STATUS");
            entity.Property(e => e.MarrriageCert)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MARRRIAGE_CERT");
            entity.Property(e => e.Military)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MILITARY");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NATIONALITY");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Privatecode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PRIVATECODE");
            entity.Property(e => e.Religion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RELIGION");
            entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Socno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOCNO");
            entity.Property(e => e.Startwork)
                .HasColumnType("datetime")
                .HasColumnName("STARTWORK");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Taxno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAXNO");
            entity.Property(e => e.Tel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TEL2");
            entity.Property(e => e.Tfname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TFNAME");
            entity.Property(e => e.Tlname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TLNAME");
            entity.Property(e => e.Tnic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TNIC");
            entity.Property(e => e.Ttname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TTNAME");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<HrRecruit2>(entity =>
        {
            entity.ToTable("HR_RECRUIT2");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT2_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT2_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BoyAmt).HasColumnName("BOY_AMT");
            entity.Property(e => e.BrethrenAmt).HasColumnName("BRETHREN_AMT");
            entity.Property(e => e.ChildAmt).HasColumnName("CHILD_AMT");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.GirlAmt).HasColumnName("GIRL_AMT");
            entity.Property(e => e.ManAmt).HasColumnName("MAN_AMT");
            entity.Property(e => e.MyNo).HasColumnName("MY_NO");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.WomAmt).HasColumnName("WOM_AMT");
        });

        modelBuilder.Entity<HrRecruit3Child>(entity =>
        {
            entity.ToTable("HR_RECRUIT3_CHILD");

            entity.HasIndex(e => e.ChildNo, "IX_HR_RECRUIT3_CHILD_CHILD_NO");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT3_CHILD_RID");

            entity.HasIndex(e => e.Sex, "IX_HR_RECRUIT3_CHILD_SEX");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT3_CHILD_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Addr)
                .HasColumnType("text")
                .HasColumnName("ADDR");
            entity.Property(e => e.Birthyear).HasColumnName("BIRTHYEAR");
            entity.Property(e => e.ChildNo).HasColumnName("CHILD_NO");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.EduLevel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EDU_LEVEL");
            entity.Property(e => e.EduOrOffice)
                .HasColumnType("text")
                .HasColumnName("EDU_OR_OFFICE");
            entity.Property(e => e.Fullname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Position)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("POSITION");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit4Fam>(entity =>
        {
            entity.ToTable("HR_RECRUIT4_FAM");

            entity.HasIndex(e => e.FamType, "IX_HR_RECRUIT4_FAM_FAM_TYPE");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT4_FAM_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT4_FAM_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.FamType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FAM_TYPE");
            entity.Property(e => e.Fullname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Life)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LIFE");
            entity.Property(e => e.Officeaddr)
                .HasColumnType("text")
                .HasColumnName("OFFICEADDR");
            entity.Property(e => e.Posi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSI");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit5Addr>(entity =>
        {
            entity.ToTable("HR_RECRUIT5_ADDR");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT5_ADDR_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT5_ADDR_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Addr)
                .HasColumnType("text")
                .HasColumnName("ADDR");
            entity.Property(e => e.Addrindex).HasColumnName("ADDRINDEX");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<HrRecruit6Work>(entity =>
        {
            entity.ToTable("HR_RECRUIT6_WORK");

            entity.HasIndex(e => e.Posiindex, "IX_HR_RECRUIT6_WORK_POSIINDEX");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT6_WORK_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Companyaddr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("COMPANYADDR");
            entity.Property(e => e.Companyname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPANYNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Jobdesc)
                .HasColumnType("text")
                .HasColumnName("JOBDESC");
            entity.Property(e => e.Posiindex).HasColumnName("POSIINDEX");
            entity.Property(e => e.Positionname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSITIONNAME");
            entity.Property(e => e.Quitreason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("QUITREASON");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Salary).HasColumnName("SALARY");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit7Edu>(entity =>
        {
            entity.ToTable("HR_RECRUIT7_EDU");

            entity.HasIndex(e => e.Eduindex, "IX_HR_RECRUIT7_EDU_EDUINDEX");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT7_EDU_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT7_EDU_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Certname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CERTNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Eduindex).HasColumnName("EDUINDEX");
            entity.Property(e => e.Edulevel)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EDULEVEL");
            entity.Property(e => e.Endyear).HasColumnName("ENDYEAR");
            entity.Property(e => e.Grad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GRAD");
            entity.Property(e => e.InstituteName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("INSTITUTE_NAME");
            entity.Property(e => e.Major)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAJOR");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Startyear).HasColumnName("STARTYEAR");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit8Skill>(entity =>
        {
            entity.ToTable("HR_RECRUIT8_SKILL");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT8_SKILL_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT8_SKILL_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Carcert).HasColumnName("CARCERT");
            entity.Property(e => e.Carskill).HasColumnName("CARSKILL");
            entity.Property(e => e.Comskill)
                .HasColumnType("text")
                .HasColumnName("COMSKILL");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Engskill)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ENGSKILL");
            entity.Property(e => e.Langskill)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LANGSKILL");
            entity.Property(e => e.Mbikecert).HasColumnName("MBIKECERT");
            entity.Property(e => e.Mbikeskill).HasColumnName("MBIKESKILL");
            entity.Property(e => e.Other)
                .HasColumnType("text")
                .HasColumnName("OTHER");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Thaiskill)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("THAISKILL");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruit9Ref>(entity =>
        {
            entity.ToTable("HR_RECRUIT9_REF");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT9_REF_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT9_REF_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Refindex).HasColumnName("REFINDEX");
            entity.Property(e => e.Relation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RELATION");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruitOther>(entity =>
        {
            entity.ToTable("HR_RECRUIT_OTHER");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT_OTHER_RID");

            entity.HasIndex(e => e.Stt, "IX_HR_RECRUIT_OTHER_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.GuaranteeCash).HasColumnName("GUARANTEE_CASH");
            entity.Property(e => e.Induce)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INDUCE");
            entity.Property(e => e.RecheckOrg).HasColumnName("RECHECK_ORG");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<HrRecruitVaccine>(entity =>
        {
            entity.ToTable("HR_RECRUIT_VACCINE");

            entity.HasIndex(e => e.Rid, "HR_RECRUIT_VACCINE_RID");

            entity.HasIndex(e => e.VacId, "HR_RECRUIT_VACCINE_VAC_ID");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT_VACCINE_RID");

            entity.HasIndex(e => e.VacId, "IX_HR_RECRUIT_VACCINE_VAC_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.VacDate)
                .HasColumnType("datetime")
                .HasColumnName("VAC_DATE");
            entity.Property(e => e.VacId).HasColumnName("VAC_ID");
            entity.Property(e => e.VacIndex).HasColumnName("VAC_INDEX");
        });

        modelBuilder.Entity<HrRecruitVaccinestt>(entity =>
        {
            entity.ToTable("HR_RECRUIT_VACCINESTT");

            entity.HasIndex(e => e.Rid, "HR_RECRUIT_VACCINESTT_RID");

            entity.HasIndex(e => e.Rid, "IX_HR_RECRUIT_VACCINESTT_RID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.VacRemark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("VAC_REMARK");
            entity.Property(e => e.VacStt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VAC_STT");
        });

        modelBuilder.Entity<HrResource>(entity =>
        {
            entity.ToTable("HR_RESOURCE");

            entity.HasIndex(e => e.Code, "IX_HR_RESOURCE_CODE");

            entity.HasIndex(e => e.Stt, "IX_HR_RESOURCE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Already).HasColumnName("ALREADY");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Manpower).HasColumnName("MANPOWER");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<IntDocform>(entity =>
        {
            entity.ToTable("INT_DOCFORM");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Dcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCODE");
            entity.Property(e => e.Ddesp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DDESP");
            entity.Property(e => e.Dname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<IntDocrunning>(entity =>
        {
            entity.HasKey(e => e.Doccode);

            entity.ToTable("INT_DOCRUNNING");

            entity.HasIndex(e => e.Doccode, "INT_DOCRUNNING_DOCCODE");

            entity.HasIndex(e => e.Runyear, "INT_DOCRUNNING_RUNYEAR");

            entity.HasIndex(e => e.Runyear, "IX_INT_DOCRUNNING_RUNYEAR");

            entity.Property(e => e.Doccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOCCODE");
            entity.Property(e => e.Lastupdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Runno).HasColumnName("RUNNO");
            entity.Property(e => e.Runyear).HasColumnName("RUNYEAR");
        });

        modelBuilder.Entity<IntMeetroom>(entity =>
        {
            entity.ToTable("INT_MEETROOMS");

            entity.HasIndex(e => e.Code, "IX_INT_MEETROOMS_CODE");

            entity.HasIndex(e => e.Ready2use, "IX_INT_MEETROOMS_READY2USE");

            entity.HasIndex(e => e.Stt, "IX_INT_MEETROOMS_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Ready2use)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("READY2USE");
            entity.Property(e => e.Roomtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ROOMTYPE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<IvtStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IVT_STAT__3214EC275AA350A4");

            entity.ToTable("IVT_STATUS");

            entity.HasIndex(e => e.Code, "IVT_STATUS_IVTSTATUS_CODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamids)
                .HasColumnType("text")
                .HasColumnName("TEAMIDS");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<JirReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JIR_REPO__3214EC27FF36ECCD");

            entity.ToTable("JIR_REPORTS");

            entity.HasIndex(e => e.Code, "JIR_REPORTS_CODE");

            entity.HasIndex(e => e.Frmname, "JIR_REPORTS_FRMNAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Caption)
                .HasMaxLength(200)
                .HasColumnName("CAPTION");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.Frmname)
                .HasMaxLength(50)
                .HasColumnName("FRMNAME");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
        });

        modelBuilder.Entity<JobPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JOB_POSI__3214EC276D2A834B");

            entity.ToTable("JOB_POSITION");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasMaxLength(255)
                .HasColumnName("DESP");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("POSITION");
            entity.Property(e => e.Stt)
                .HasMaxLength(255)
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<JqzAn>(entity =>
        {
            entity.ToTable("JQZ_ANS");

            entity.HasIndex(e => e.Id, "IX_JQZ_ANS_SEQ");

            entity.HasIndex(e => e.Stt, "IX_JQZ_ANS_STT");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Anstext)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ANSTEXT");
            entity.Property(e => e.Qid).HasColumnName("QID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<JqzAnsuser>(entity =>
        {
            entity.ToTable("JQZ_ANSUSER");

            entity.HasIndex(e => e.Stt, "IX_JQZ_ANSUSER_STT");

            entity.HasIndex(e => e.Utype, "IX_JQZ_ANSUSER_UTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Fname)
                .HasMaxLength(200)
                .HasColumnName("FNAME");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Idcard)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lname)
                .HasMaxLength(200)
                .HasColumnName("LNAME");
            entity.Property(e => e.Protype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROTYPE");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tname)
                .HasMaxLength(20)
                .HasColumnName("TNAME");
            entity.Property(e => e.Utype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UTYPE");
        });

        modelBuilder.Entity<JqzAnsval>(entity =>
        {
            entity.ToTable("JQZ_ANSVAL");

            entity.HasIndex(e => e.CreateDate, "IX_JQZ_ANSVAL_CREATE_DATE");

            entity.HasIndex(e => e.Qid, "IX_JQZ_ANSVAL_QID");

            entity.HasIndex(e => e.Uid, "IX_JQZ_ANSVAL_UID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Boolvalue).HasColumnName("BOOLVALUE");
            entity.Property(e => e.ChoiceId).HasColumnName("CHOICE_ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Qid).HasColumnName("QID");
            entity.Property(e => e.Textvalue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TEXTVALUE");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<JqzQuest>(entity =>
        {
            entity.ToTable("JQZ_QUEST");

            entity.HasIndex(e => e.Seq, "IX_JQZ_QUEST_SEQ");

            entity.HasIndex(e => e.Stt, "IX_JQZ_QUEST_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atype)
                .HasDefaultValueSql("((1))")
                .HasComment("1=boolean / 2=text / 3=choise / 4 = multiselect")
                .HasColumnName("ATYPE");
            entity.Property(e => e.IsforceValie)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ISFORCE_VALIE");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Quest)
                .HasColumnType("text")
                .HasColumnName("QUEST");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Zid).HasColumnName("ZID");
        });

        modelBuilder.Entity<JqzQuiz>(entity =>
        {
            entity.ToTable("JQZ_QUIZ");

            entity.HasIndex(e => e.CreateDate, "IX_JQZ_QUIZ_CREATE_DATE");

            entity.HasIndex(e => e.Stt, "IX_JQZ_QUIZ_STT");

            entity.HasIndex(e => e.Utype, "IX_JQZ_QUIZ_UTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESP");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRE_DATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Utype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UTYPE");
        });

        modelBuilder.Entity<JsaAccesslog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JSA_ACCE__3214EC27C8F45683");

            entity.ToTable("JSA_ACCESSLOG");

            entity.HasIndex(e => e.Tokenid, "JSA_ACCESSLOG_TOKENID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AccessFunc)
                .HasMaxLength(200)
                .HasColumnName("ACCESS_FUNC");
            entity.Property(e => e.Accessed).HasColumnName("ACCESSED");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Tokenid).HasColumnName("TOKENID");
        });

        modelBuilder.Entity<JsaAccesstoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JSA_ACCE__3214EC27FC5DCD10");

            entity.ToTable("JSA_ACCESSTOKEN");

            entity.HasIndex(e => e.Authid, "JSA_ACCESSTOKEN_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Accesslimit).HasColumnName("ACCESSLIMIT");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Authid).HasColumnName("AUTHID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Token)
                .HasMaxLength(200)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Tokenid).HasColumnName("TOKENID");
        });

        modelBuilder.Entity<JsaActionlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JSA_ACTI__3214EC27C3559FDE");

            entity.ToTable("JSA_ACTIONLOG");

            entity.HasIndex(e => e.Token, "JSA_ACTIONLOG_TOKEN");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Msg)
                .HasMaxLength(255)
                .HasColumnName("MSG");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<JsaAuthenid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JSA_AUTH__3214EC27F5E93EFA");

            entity.ToTable("JSA_AUTHENID");

            entity.HasIndex(e => e.Teamid, "JSA_AUTHENID_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Authcode)
                .HasMaxLength(200)
                .HasColumnName("AUTHCODE");
            entity.Property(e => e.Pack)
                .HasMaxLength(3)
                .HasColumnName("PACK");
            entity.Property(e => e.Secretcode)
                .HasMaxLength(200)
                .HasColumnName("SECRETCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<Leavetype>(entity =>
        {
            entity.ToTable("LEAVETYPE");

            entity.HasIndex(e => e.Leavetype1, "IX_LEAVETYPE_LEAVETYPE");

            entity.HasIndex(e => e.Stt, "IX_LEAVETYPE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Desp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESP");
            entity.Property(e => e.Leavename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LEAVENAME");
            entity.Property(e => e.Leavetype1).HasColumnName("LEAVETYPE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<MasCrmcalltime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAS_CRMC__3214EC27B4043D39");

            entity.ToTable("MAS_CRMCALLTIME");

            entity.HasIndex(e => e.Stt, "CRMADDR_STT");

            entity.HasIndex(e => e.Idx, "MAS_CRMCALLTIME_IDX");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Disc)
                .HasMaxLength(250)
                .HasColumnName("DISC");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Idx).HasColumnName("IDX");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<MasThpDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__MAS_THP___F24D1D90A196FC40");

            entity.ToTable("MAS_THP_DISTRICT");

            entity.Property(e => e.DistrictId)
                .ValueGeneratedNever()
                .HasColumnName("DISTRICT_ID");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_NAME");
            entity.Property(e => e.GeoId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GEO_ID");
            entity.Property(e => e.ProvinceId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PROVINCE_ID");
        });

        modelBuilder.Entity<MasThpGeography>(entity =>
        {
            entity.HasKey(e => e.GeoId).HasName("PK__MAS_THP___A3BCFD1EA210D346");

            entity.ToTable("MAS_THP_GEOGRAPHY");

            entity.Property(e => e.GeoId)
                .ValueGeneratedNever()
                .HasColumnName("GEO_ID");
            entity.Property(e => e.GeoName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GEO_NAME");
        });

        modelBuilder.Entity<MasThpProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK__MAS_THP___33EF610E2E57748C");

            entity.ToTable("MAS_THP_PROVINCE");

            entity.Property(e => e.ProvinceId)
                .ValueGeneratedNever()
                .HasColumnName("PROVINCE_ID");
            entity.Property(e => e.GeoId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GEO_ID");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_NAME");
        });

        modelBuilder.Entity<MasThpSubdistrict>(entity =>
        {
            entity.HasKey(e => e.SubdistrictId).HasName("PK__MAS_THP___F6DFC00DD1AA95ED");

            entity.ToTable("MAS_THP_SUBDISTRICT");

            entity.Property(e => e.SubdistrictId)
                .ValueGeneratedNever()
                .HasColumnName("SUBDISTRICT_ID");
            entity.Property(e => e.DistrictId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DISTRICT_ID");
            entity.Property(e => e.GeoId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GEO_ID");
            entity.Property(e => e.ProvinceId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PROVINCE_ID");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.SubdistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_NAME");
        });

        modelBuilder.Entity<MasThpZipcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAS_THP___3214EC2700B27C22");

            entity.ToTable("MAS_THP_ZIPCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<MasVaccine>(entity =>
        {
            entity.ToTable("MAS_VACCINE");

            entity.HasIndex(e => e.Stt, "IX_MAS_VACCINE_STT");

            entity.HasIndex(e => e.VacCode, "IX_MAS_VACCINE_VAC_CODE");

            entity.HasIndex(e => e.VacType, "IX_MAS_VACCINE_VAC_TYPE");

            entity.HasIndex(e => e.Stt, "MAS_VACCINE_STT");

            entity.HasIndex(e => e.VacCode, "MAS_VACCINE_VAC_CODE");

            entity.HasIndex(e => e.VacType, "MAS_VACCINE_VAC_TYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Desp)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESP");
            entity.Property(e => e.Prior).HasColumnName("PRIOR");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.VacCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VAC_CODE");
            entity.Property(e => e.VacEnname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VAC_ENNAME");
            entity.Property(e => e.VacThname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VAC_THNAME");
            entity.Property(e => e.VacType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VAC_TYPE");
        });

        modelBuilder.Entity<MdlSpOfftakeAreaYearSum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC279A4DD764");

            entity.ToTable("mdl_SP_OfftakeAreaYearSum");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areacode)
                .HasMaxLength(255)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areamonth).HasColumnName("AREAMONTH");
            entity.Property(e => e.Areaname)
                .HasMaxLength(255)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeChartAccMonth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC278914E635");

            entity.ToTable("mdl_SP_OfftakeChartAccMonth");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Storegroupname)
                .HasMaxLength(255)
                .HasColumnName("STOREGROUPNAME");
        });

        modelBuilder.Entity<MdlSpOfftakeChartAreaMonth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC27EAE3FAE8");

            entity.ToTable("mdl_SP_OfftakeChartAreaMonth");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeD2dstaffSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC2733C33C47");

            entity.ToTable("mdl_SP_OfftakeD2DStaffSales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(255)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(255)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeProductMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC27DC59F026");

            entity.ToTable("mdl_SP_OfftakeProductMonthly");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(255)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandid).HasColumnName("BRANDID");
            entity.Property(e => e.Brandname)
                .HasMaxLength(255)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Productcode)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Productname)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeProductSkumonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC2787A491B1");

            entity.ToTable("mdl_SP_OfftakeProductSKUMonthly");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(255)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(255)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeStaffSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC275E52B93A");

            entity.ToTable("mdl_SP_OfftakeStaffSales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Empcode)
                .HasMaxLength(255)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(255)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(255)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(255)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeStoreSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC27ADF3D7AD");

            entity.ToTable("mdl_SP_OfftakeStoreSale");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeStoreSumm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC278D2F9B11");

            entity.ToTable("mdl_SP_OfftakeStoreSumm");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Skucode)
                .HasMaxLength(255)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(255)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(255)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(255)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeSupSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC27DB27F6EC");

            entity.ToTable("mdl_SP_OfftakeSupSales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Storegroupname)
                .HasMaxLength(255)
                .HasColumnName("STOREGROUPNAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(255)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supname)
                .HasMaxLength(255)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<MdlSpOfftakeSupSelfSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mdl_SP_O__3214EC27E8EACC83");

            entity.ToTable("mdl_SP_OfftakeSupSelfSales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amt).HasColumnName("AMT");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("DISC");
            entity.Property(e => e.Storecode)
                .HasMaxLength(255)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(255)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NEWS__3214EC2776FCE8AA");

            entity.ToTable("NEWS");

            entity.HasIndex(e => e.Id, "NEWS_ID");

            entity.HasIndex(e => e.Stt, "NEWS_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Detail)
                .HasColumnType("text")
                .HasColumnName("DETAIL");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Imgurl)
                .HasColumnType("text")
                .HasColumnName("IMGURL");
            entity.Property(e => e.Linkurl)
                .HasColumnType("text")
                .HasColumnName("LINKURL");
            entity.Property(e => e.Newsdate)
                .HasColumnType("datetime")
                .HasColumnName("NEWSDATE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasMaxLength(255)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("TITLE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Newsfeed>(entity =>
        {
            entity.ToTable("NEWSFEEDS");

            entity.HasIndex(e => e.Active, "IX_NEWSFEEDS_ACTIVE");

            entity.HasIndex(e => e.CreateDate, "IX_NEWSFEEDS_CREATE_DATE");

            entity.HasIndex(e => e.Priority, "IX_NEWSFEEDS_PRIORITY");

            entity.HasIndex(e => e.Stt, "IX_NEWSFEEDS_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Detail)
                .HasColumnType("text")
                .HasColumnName("DETAIL");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Reading).HasColumnName("READING");
            entity.Property(e => e.RedirectUrl)
                .HasColumnType("text")
                .HasColumnName("REDIRECT_URL");
            entity.Property(e => e.Showing)
                .HasColumnType("text")
                .HasColumnName("SHOWING");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Subject)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<OnlineRegisted>(entity =>
        {
            entity.ToTable("ONLINE_REGISTED");

            entity.HasIndex(e => e.Empid, "IX_ONLINE_REGISTED_EMPID");

            entity.HasIndex(e => e.Regisid, "IX_ONLINE_REGISTED_REGISID");

            entity.HasIndex(e => e.Stt, "IX_ONLINE_REGISTED_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Distance)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISTANCE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Imagefile)
                .HasMaxLength(100)
                .HasColumnName("IMAGEFILE");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Otp)
                .HasMaxLength(6)
                .HasColumnName("OTP");
            entity.Property(e => e.Regisid).HasColumnName("REGISID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.ValidateLocation).HasColumnName("VALIDATE_LOCATION");
        });

        modelBuilder.Entity<OnlineRegistration>(entity =>
        {
            entity.ToTable("ONLINE_REGISTRATION");

            entity.HasIndex(e => e.ActiveDate, "IX_ONLINE_REGISTRATION_ACTIVE_DATE");

            entity.HasIndex(e => e.Regname, "IX_ONLINE_REGISTRATION_REGNAME");

            entity.HasIndex(e => e.RegType, "IX_ONLINE_REGISTRATION_REG_TYPE");

            entity.HasIndex(e => e.Stt, "IX_ONLINE_REGISTRATION_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActiveDate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DeactiveDate)
                .HasColumnType("datetime")
                .HasColumnName("DEACTIVE_DATE");
            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.GpsLat)
                .HasMaxLength(50)
                .HasColumnName("GPS_LAT");
            entity.Property(e => e.GpsLng)
                .HasMaxLength(50)
                .HasColumnName("GPS_LNG");
            entity.Property(e => e.Linetoken)
                .HasMaxLength(100)
                .HasColumnName("LINETOKEN");
            entity.Property(e => e.PersonLimit).HasColumnName("PERSON_LIMIT");
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .HasColumnName("PLACE");
            entity.Property(e => e.RegType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REG_TYPE");
            entity.Property(e => e.Regcode)
                .HasMaxLength(50)
                .HasColumnName("REGCODE");
            entity.Property(e => e.Regname)
                .HasMaxLength(200)
                .HasColumnName("REGNAME");
            entity.Property(e => e.Report2mail)
                .HasMaxLength(50)
                .HasColumnName("REPORT2MAIL");
            entity.Property(e => e.Schedule)
                .HasColumnType("ntext")
                .HasColumnName("SCHEDULE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Oo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OOS__3214EC27B29518C3");

            entity.ToTable("OOS");

            entity.HasIndex(e => e.Atdate, "OOS_ATDATE");

            entity.HasIndex(e => e.ProductskuId, "OOS_PRODUCTSKU_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Bring).HasColumnName("BRING");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.IvtstatusId).HasColumnName("IVTSTATUS_ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Stocktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STOCKTYPE");
            entity.Property(e => e.StoreId).HasColumnName("STORE_ID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__POSITION__3214EC27D625F4B2");

            entity.ToTable("POSITION");

            entity.HasIndex(e => e.Posicode, "POSITION_POSICODE");

            entity.HasIndex(e => e.Stt, "POSITION_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Posicode)
                .HasMaxLength(50)
                .HasColumnName("POSICODE");
            entity.Property(e => e.Posiname)
                .HasMaxLength(200)
                .HasColumnName("POSINAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT__3214EC27EED57279");

            entity.ToTable("PRODUCT");

            entity.HasIndex(e => e.BrandId, "IX_PRODUCT_BRAND_ID");

            entity.HasIndex(e => e.Productcode, "PRODUCT_PRODUCTCODE");

            entity.HasIndex(e => e.ProducttypeId, "PRODUCT_PRODUCTTYPE_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discontinued)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("DISCONTINUED");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProducttypeId).HasColumnName("PRODUCTTYPE_ID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("ntext")
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ProductPricerate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC2715571B08");

            entity.ToTable("PRODUCT_PRICERATE");

            entity.HasIndex(e => e.Atdate, "PRODUCT_PRICERATE_ATDATE");

            entity.HasIndex(e => e.ProductskuId, "PRODUCT_PRICERATE_PRODUCTSKU_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DiscountPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DISCOUNT_PRICE");
            entity.Property(e => e.MemberPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MEMBER_PRICE");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.PromoPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROMO_PRICE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Productpricetype>(entity =>
        {
            entity.ToTable("PRODUCTPRICETYPE");

            entity.HasIndex(e => e.Active, "IX_PRODUCTPRICETYPE_ACTIVE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<Productsku>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTS__3214EC27E4E63106");

            entity.ToTable("PRODUCTSKU");

            entity.HasIndex(e => e.ProductId, "PRODUCTSKU_PRODUCT_ID");

            entity.HasIndex(e => e.Skucode, "PRODUCTSKU_SKUCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discontinued)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("DISCONTINUED");
            entity.Property(e => e.ProductDetail)
                .HasColumnType("ntext")
                .HasColumnName("PRODUCT_DETAIL");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("ntext")
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<ProductskuPricesurvey>(entity =>
        {
            entity.ToTable("PRODUCTSKU_PRICESURVEY");

            entity.HasIndex(e => e.Atdate, "IX_PRODUCTSKU_PRICESURVEY_ATDATE");

            entity.HasIndex(e => e.Pricetype, "IX_PRODUCTSKU_PRICESURVEY_PRICETYPE");

            entity.HasIndex(e => e.Skuid, "IX_PRODUCTSKU_PRICESURVEY_SKUID");

            entity.HasIndex(e => e.Stt, "IX_PRODUCTSKU_PRICESURVEY_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Priceavg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEAVG");
            entity.Property(e => e.Pricemax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEMAX");
            entity.Property(e => e.Pricemin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEMIN");
            entity.Property(e => e.Pricetype).HasColumnName("PRICETYPE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ProductskuSo>(entity =>
        {
            entity.ToTable("PRODUCTSKU_SOS");

            entity.HasIndex(e => e.Atdate, "IX_PRODUCTSKU_SOS_ATDATE");

            entity.HasIndex(e => e.Storeid, "IX_PRODUCTSKU_SOS_STOREID");

            entity.HasIndex(e => e.Stt, "IX_PRODUCTSKU_SOS_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShelfH).HasColumnName("SHELF_H");
            entity.Property(e => e.ShelfL).HasColumnName("SHELF_L");
            entity.Property(e => e.ShelfW).HasColumnName("SHELF_W");
            entity.Property(e => e.Shelftypeid).HasColumnName("SHELFTYPEID");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Producttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTT__3214EC27FFF13365");

            entity.ToTable("PRODUCTTYPE");

            entity.HasIndex(e => e.Producttypecode, "PRODUCTTYPE_PRODUCTTYPECODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discontinued)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("DISCONTINUED");
            entity.Property(e => e.Producttypecode)
                .HasMaxLength(50)
                .HasColumnName("PRODUCTTYPECODE");
            entity.Property(e => e.Producttypename)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTTYPENAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<QuaSlip>(entity =>
        {
            entity.ToTable("QUA_SLIP");

            entity.HasIndex(e => e.Teamid, "IX_QUA_SLIP_TEAMID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedCount).HasColumnName("CREATED_COUNT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<RecMinaddr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINA__3214EC279243DACF");

            entity.ToTable("REC_MINADDR");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(255)
                .HasColumnName("ADDR");
            entity.Property(e => e.Addrtype).HasColumnName("ADDRTYPE");
            entity.Property(e => e.District)
                .HasMaxLength(255)
                .HasColumnName("DISTRICT");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Province)
                .HasMaxLength(255)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(255)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<RecMineducat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINE__3214EC2721FE41C3");

            entity.ToTable("REC_MINEDUCAT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EdulevCode)
                .HasMaxLength(255)
                .HasColumnName("EDULEV_CODE");
            entity.Property(e => e.Endyear).HasColumnName("ENDYEAR");
            entity.Property(e => e.Grade)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("GRADE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Major)
                .HasMaxLength(255)
                .HasColumnName("MAJOR");
            entity.Property(e => e.School)
                .HasMaxLength(255)
                .HasColumnName("SCHOOL");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Startyear).HasColumnName("STARTYEAR");
        });

        modelBuilder.Entity<RecMinexper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINE__3214EC27DDFFC743");

            entity.ToTable("REC_MINEXPER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("COMPANY");
            entity.Property(e => e.CompanyAddr)
                .HasMaxLength(255)
                .HasColumnName("COMPANY_ADDR");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Jd)
                .HasMaxLength(255)
                .HasColumnName("JD");
            entity.Property(e => e.Positionname)
                .HasMaxLength(255)
                .HasColumnName("POSITIONNAME");
            entity.Property(e => e.Salary).HasColumnName("SALARY");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Tel)
                .HasMaxLength(255)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<RecMinhistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINH__3214EC273C514417");

            entity.ToTable("REC_MINHISTORY");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fname)
                .HasMaxLength(255)
                .HasColumnName("FNAME");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Lname)
                .HasMaxLength(255)
                .HasColumnName("LNAME");
            entity.Property(e => e.Nat)
                .HasMaxLength(255)
                .HasColumnName("NAT");
            entity.Property(e => e.Nname)
                .HasMaxLength(255)
                .HasColumnName("NNAME");
            entity.Property(e => e.PositionId).HasColumnName("POSITION_ID");
            entity.Property(e => e.Reg)
                .HasMaxLength(255)
                .HasColumnName("REG");
            entity.Property(e => e.SalaryReq).HasColumnName("SALARY_REQ");
            entity.Property(e => e.Sex)
                .HasMaxLength(255)
                .HasColumnName("SEX");
            entity.Property(e => e.Soldstatus)
                .HasMaxLength(255)
                .HasColumnName("SOLDSTATUS");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stt)
                .HasMaxLength(255)
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(255)
                .HasColumnName("TEL");
            entity.Property(e => e.Tname)
                .HasMaxLength(255)
                .HasColumnName("TNAME");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Validcode)
                .HasMaxLength(255)
                .HasColumnName("VALIDCODE");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<RecMinskill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINS__3214EC27E338562A");

            entity.ToTable("REC_MINSKILL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CarLicense)
                .HasMaxLength(255)
                .HasColumnName("CAR_LICENSE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.MbikeLicense)
                .HasMaxLength(255)
                .HasColumnName("MBIKE_LICENSE");
            entity.Property(e => e.SkillCar)
                .HasMaxLength(255)
                .HasColumnName("SKILL_CAR");
            entity.Property(e => e.SkillComp)
                .HasMaxLength(255)
                .HasColumnName("SKILL_COMP");
            entity.Property(e => e.SkillMbike)
                .HasMaxLength(255)
                .HasColumnName("SKILL_MBIKE");
            entity.Property(e => e.SkillOth)
                .HasMaxLength(255)
                .HasColumnName("SKILL_OTH");
        });

        modelBuilder.Entity<RecMinskilllang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REC_MINS__3214EC2730718B96");

            entity.ToTable("REC_MINSKILLLANG");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Language)
                .HasMaxLength(255)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.SkRead).HasColumnName("SK_READ");
            entity.Property(e => e.SkSpek).HasColumnName("SK_SPEK");
            entity.Property(e => e.SkWrit).HasColumnName("SK_WRIT");
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECEIPT__3214EC2757DA05FF");

            entity.ToTable("RECEIPT");

            entity.HasIndex(e => e.Stt, "IX_RECEIPT_STT");

            entity.HasIndex(e => e.Hid, "RECEIPT_HID");

            entity.HasIndex(e => e.ProductskuId, "RECEIPT_PRODUCTSKU_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasColumnName("REMARK");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ReceiptCanceled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECEIPT___3214EC2716D51B1F");

            entity.ToTable("RECEIPT_CANCELED");

            entity.HasIndex(e => e.Receiptid, "RECEIPT_CANCELED_RECEIPTID");

            entity.HasIndex(e => e.ReceiptRunno, "RECEIPT_CANCELED_RECEIPT_RUNNO");

            entity.HasIndex(e => e.Storeid, "RECEIPT_CANCELED_STOREID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CancelRemark)
                .HasMaxLength(200)
                .HasColumnName("CANCEL_REMARK");
            entity.Property(e => e.CancelType).HasColumnName("CANCEL_TYPE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.ReceiptRunno)
                .HasMaxLength(50)
                .HasColumnName("RECEIPT_RUNNO");
            entity.Property(e => e.ReceiptRunnoCan)
                .HasMaxLength(50)
                .HasColumnName("RECEIPT_RUNNO_CAN");
            entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");
            entity.Property(e => e.ReceiptidCan).HasColumnName("RECEIPTID_CAN");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ReceiptH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECEIPT___3214EC27D71C3F4E");

            entity.ToTable("RECEIPT_H");

            entity.HasIndex(e => e.Stt, "IX_RECEIPT_H_STT");

            entity.HasIndex(e => e.Atdate, "RECEIPT_H_ATDATE");

            entity.HasIndex(e => e.Runno, "RECEIPT_H_RUNNO");

            entity.HasIndex(e => e.Storeid, "RECEIPT_H_STOREID");

            entity.HasIndex(e => e.Teamid, "RECEIPT_H_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Pay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PAY");
            entity.Property(e => e.Realprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REALPRICE");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasColumnName("REMARK");
            entity.Property(e => e.Runno)
                .HasMaxLength(100)
                .HasColumnName("RUNNO");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ReceiptTotal>(entity =>
        {
            entity.ToTable("RECEIPT_TOTAL");

            entity.HasIndex(e => e.Atdate, "IX_RECEIPT_TOTAL_ATDATE");

            entity.HasIndex(e => e.Storeid, "IX_RECEIPT_TOTAL_STOREID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<RunReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RUN_RECE__3214EC27F2EEDC3D");

            entity.ToTable("RUN_RECEIPT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ReceiptCode)
                .HasMaxLength(50)
                .HasColumnName("RECEIPT_CODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<RunStockcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RUN_STOC__3214EC27DE510255");

            entity.ToTable("RUN_STOCKCARD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cardcode)
                .HasMaxLength(50)
                .HasColumnName("CARDCODE");
            entity.Property(e => e.Stocktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STOCKTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<SalaryslipDdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SALARYSL__3214EC276BFC65A5");

            entity.ToTable("SALARYSLIP_DDATA");

            entity.HasIndex(e => e.Empid, "SALARYSLIP_DDATA_EMPID");

            entity.HasIndex(e => e.Hid, "SALARYSLIP_DDATA_HID");

            entity.HasIndex(e => e.Stt, "SALARYSLIP_DDATA_STT");

            entity.HasIndex(e => e.Type, "SALARYSLIP_DDATA_TYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DtlId).HasColumnName("DTL_ID");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<SalaryslipDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SALARYSLIP_DTL");

            entity.HasIndex(e => e.DtlType, "SALARYSLIP_DTL_DTL_TYPE");

            entity.Property(e => e.DtlCap)
                .HasMaxLength(255)
                .HasColumnName("DTL_CAP");
            entity.Property(e => e.DtlType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .IsFixedLength()
                .HasColumnName("DTL_TYPE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SalaryslipFoot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SALARYSL__3214EC2769D25F4B");

            entity.ToTable("SALARYSLIP_FOOT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ExpenNetCap)
                .HasMaxLength(255)
                .HasColumnName("EXPEN_NET_CAP");
            entity.Property(e => e.IncomeAllCap)
                .HasMaxLength(255)
                .HasColumnName("INCOME_ALL_CAP");
            entity.Property(e => e.IncomeCollectCap)
                .HasMaxLength(255)
                .HasColumnName("INCOME_COLLECT_CAP");
            entity.Property(e => e.IncomeNetCap)
                .HasMaxLength(255)
                .HasColumnName("INCOME_NET_CAP");
            entity.Property(e => e.ResfunCollectCap)
                .HasMaxLength(255)
                .HasColumnName("RESFUN_COLLECT_CAP");
            entity.Property(e => e.SsCollectCap)
                .HasMaxLength(255)
                .HasColumnName("SS_COLLECT_CAP");
            entity.Property(e => e.TaxCollectCap)
                .HasMaxLength(255)
                .HasColumnName("TAX_COLLECT_CAP");
        });

        modelBuilder.Entity<SalaryslipHdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SALARYSL__3214EC2767C39C05");

            entity.ToTable("SALARYSLIP_HDATA");

            entity.HasIndex(e => e.Empcode, "SALARYSLIP_HDATA_EMPCODE");

            entity.HasIndex(e => e.Empid, "SALARYSLIP_HDATA_EMPID");

            entity.HasIndex(e => e.Hid, "SALARYSLIP_HDATA_HID");

            entity.HasIndex(e => e.Stt, "SALARYSLIP_HDATA_STT");

            entity.HasIndex(e => e.Teamid, "SALARYSLIP_HDATA_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActiveDate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.ContacttypeData)
                .HasMaxLength(255)
                .HasColumnName("CONTACTTYPE_DATA");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DepartmentData)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMENT_DATA");
            entity.Property(e => e.Empcode)
                .HasMaxLength(255)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.ExpenNetData)
                .HasMaxLength(255)
                .HasColumnName("EXPEN_NET_DATA");
            entity.Property(e => e.FullnameData)
                .HasMaxLength(255)
                .HasColumnName("FULLNAME_DATA");
            entity.Property(e => e.HeaderData)
                .HasMaxLength(255)
                .HasColumnName("HEADER_DATA");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.IncomeAllData)
                .HasMaxLength(255)
                .HasColumnName("INCOME_ALL_DATA");
            entity.Property(e => e.IncomeCollectData)
                .HasMaxLength(255)
                .HasColumnName("INCOME_COLLECT_DATA");
            entity.Property(e => e.IncomeNetData)
                .HasMaxLength(255)
                .HasColumnName("INCOME_NET_DATA");
            entity.Property(e => e.MonthlyData)
                .HasMaxLength(255)
                .HasColumnName("MONTHLY_DATA");
            entity.Property(e => e.PaydateData)
                .HasMaxLength(255)
                .HasColumnName("PAYDATE_DATA");
            entity.Property(e => e.ResfunCollectData)
                .HasMaxLength(255)
                .HasColumnName("RESFUN_COLLECT_DATA");
            entity.Property(e => e.RoundData)
                .HasMaxLength(255)
                .HasColumnName("ROUND_DATA");
            entity.Property(e => e.SsCollectData)
                .HasMaxLength(255)
                .HasColumnName("SS_COLLECT_DATA");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.SubheaderData)
                .HasMaxLength(255)
                .HasColumnName("SUBHEADER_DATA");
            entity.Property(e => e.TaxCollectData)
                .HasMaxLength(255)
                .HasColumnName("TAX_COLLECT_DATA");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.YearlyData)
                .HasMaxLength(255)
                .HasColumnName("YEARLY_DATA");
        });

        modelBuilder.Entity<SalaryslipHead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SALARYSL__3214EC27F3306A1F");

            entity.ToTable("SALARYSLIP_HEAD");

            entity.HasIndex(e => e.Stt, "SALARYSLIP_HEAD_STT");

            entity.HasIndex(e => e.Teamid, "SALARYSLIP_HEAD_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ContacttypeCap)
                .HasMaxLength(255)
                .HasColumnName("CONTACTTYPE_CAP");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DepartmentCap)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMENT_CAP");
            entity.Property(e => e.FullnameCap)
                .HasMaxLength(255)
                .HasColumnName("FULLNAME_CAP");
            entity.Property(e => e.HeaderCap)
                .HasMaxLength(255)
                .HasColumnName("HEADER_CAP");
            entity.Property(e => e.MonthlyCap)
                .HasMaxLength(255)
                .HasColumnName("MONTHLY_CAP");
            entity.Property(e => e.PaydateCap)
                .HasMaxLength(255)
                .HasColumnName("PAYDATE_CAP");
            entity.Property(e => e.RoundCap)
                .HasMaxLength(255)
                .HasColumnName("ROUND_CAP");
            entity.Property(e => e.Slipname)
                .HasMaxLength(255)
                .HasColumnName("SLIPNAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.SubheaderCap)
                .HasMaxLength(255)
                .HasColumnName("SUBHEADER_CAP");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.YearlyCap)
                .HasMaxLength(255)
                .HasColumnName("YEARLY_CAP");
        });

        modelBuilder.Entity<SosShelftype>(entity =>
        {
            entity.ToTable("SOS_SHELFTYPE");

            entity.HasIndex(e => e.Seq, "IX_SOS_SHELFTYPE_SEQ");

            entity.HasIndex(e => e.Shelftypecode, "IX_SOS_SHELFTYPE_SHELFTYPECODE");

            entity.HasIndex(e => e.Stt, "IX_SOS_SHELFTYPE_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Shelftypecode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHELFTYPECODE");
            entity.Property(e => e.Shelftypedesp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHELFTYPEDESP");
            entity.Property(e => e.Shelftypename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHELFTYPENAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StfAvatar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_AVAT__3214EC27E2CF138D");

            entity.ToTable("STF_AVATAR");

            entity.HasIndex(e => e.Active, "STF_AVATAR_ACTIVE");

            entity.HasIndex(e => e.Userid, "STF_AVATAR_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("('1')")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.PersonalImg)
                .HasColumnType("image")
                .HasColumnName("PERSONAL_IMG");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Version).HasColumnName("VERSION");
        });

        modelBuilder.Entity<StfCompany>(entity =>
        {
            entity.ToTable("STF_COMPANY");

            entity.HasIndex(e => e.Compcode, "IX_STF_COMPANY_COMPCODE");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.Compcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPCODE");
            entity.Property(e => e.Compname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("COMPNAME");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<StfRegsecure>(entity =>
        {
            entity.ToTable("STF_REGSECURE");

            entity.HasIndex(e => e.Empid, "EMPID");

            entity.HasIndex(e => e.Stt, "IX_STF_REGSECURE_STT");

            entity.HasIndex(e => e.Tel, "IX_STF_REGSECURE_TEL");

            entity.HasIndex(e => e.Stt, "STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.FcmToken)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FCM_TOKEN");
            entity.Property(e => e.LineToken)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LINE_TOKEN");
            entity.Property(e => e.Lineid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LINEID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StfSecureActive>(entity =>
        {
            entity.ToTable("STF_SECURE_ACTIVE");

            entity.HasIndex(e => e.Active, "ACTIVE");

            entity.HasIndex(e => e.RegSecureId, "IX_STF_SECURE_ACTIVE_REG_SECURE_ID");

            entity.HasIndex(e => e.Syscode, "IX_STF_SECURE_ACTIVE_SYSCODE");

            entity.HasIndex(e => e.Syscode, "SYSCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.ActiveDate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.ActiveIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_IP");
            entity.Property(e => e.Ipaddr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPADDR");
            entity.Property(e => e.RegSecureId).HasColumnName("REG_SECURE_ID");
            entity.Property(e => e.SecureCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SECURE_CODE");
            entity.Property(e => e.SecureCodeDate)
                .HasColumnType("datetime")
                .HasColumnName("SECURE_CODE_DATE");
            entity.Property(e => e.Syscode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SYSCODE");
        });

        modelBuilder.Entity<StfSign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_SIGN__3214EC2716C2DBCC");

            entity.ToTable("STF_SIGN");

            entity.HasIndex(e => e.Level, "STF_SIGN_LEVEL");

            entity.HasIndex(e => e.Userid, "STF_SIGN_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Activate).HasColumnName("ACTIVATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Refercode)
                .HasMaxLength(250)
                .HasColumnName("REFERCODE");
            entity.Property(e => e.Secretcode)
                .HasMaxLength(100)
                .HasColumnName("SECRETCODE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Token)
                .HasColumnType("text")
                .HasColumnName("TOKEN");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("USERID");
            entity.Property(e => e.Userpw)
                .HasMaxLength(100)
                .HasColumnName("USERPW");
        });

        modelBuilder.Entity<StfSignLog>(entity =>
        {
            entity.ToTable("STF_SIGN_LOG");

            entity.HasIndex(e => e.Empid, "EMPID");

            entity.HasIndex(e => e.Empid, "IX_STF_SIGN_LOG_EMPID");

            entity.HasIndex(e => e.Systemcode, "IX_STF_SIGN_LOG_SYSTEMCODE");

            entity.HasIndex(e => e.Systemcode, "SYSTEMCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Systemcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SYSTEMCODE");
        });

        modelBuilder.Entity<StfSignature>(entity =>
        {
            entity.ToTable("STF_SIGNATURE");

            entity.HasIndex(e => e.Stt, "IX_STF_SIGNATURE_STT");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Signkey)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SIGNKEY");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<StfTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_TEAM__3214EC27B5D7C772");

            entity.ToTable("STF_TEAM");

            entity.HasIndex(e => e.Companyid, "IX_STF_TEAM_COMPANYID");

            entity.HasIndex(e => e.Stt, "IX_STF_TEAM_STT");

            entity.HasIndex(e => e.Teamcode, "IX_STF_TEAM_TEAMCODE");

            entity.HasIndex(e => e.Teamcode, "STF_TEAMCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Domain)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.FunctionConf)
                .HasColumnType("text")
                .HasColumnName("FUNCTION_CONF");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamcode)
                .HasMaxLength(50)
                .HasColumnName("TEAMCODE");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StfTeamcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_TEAM__3214EC2779BBFDC4");

            entity.ToTable("STF_TEAMCAP");

            entity.HasIndex(e => e.Defaultcap, "STF_TEAMCAP_DEFAULTCAP");

            entity.HasIndex(e => e.Teamid, "STF_TEAMCAP_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Defaultcap)
                .HasMaxLength(100)
                .HasColumnName("DEFAULTCAP");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Transcap)
                .HasMaxLength(100)
                .HasColumnName("TRANSCAP");
        });

        modelBuilder.Entity<StfTeammenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_TEAM__3214EC27CD7A0ACE");

            entity.ToTable("STF_TEAMMENUS");

            entity.HasIndex(e => e.Menuid, "STF_TEAMMENUS_MENUID");

            entity.HasIndex(e => e.Teamid, "STF_TEAMMENUS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DeptidsPermiss)
                .HasColumnType("text")
                .HasColumnName("DEPTIDS_PERMISS");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StfUatuser>(entity =>
        {
            entity.ToTable("STF_UATUSER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Tag)
                .HasMaxLength(150)
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<StfUsergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TEAMID");

            entity.ToTable("STF_USERGROUPS");

            entity.HasIndex(e => e.Alluser, "IX_STF_USERGROUPS_ALLUSER");

            entity.HasIndex(e => e.Groupcode, "IX_STF_USERGROUPS_GROUPCODE").IsUnique();

            entity.HasIndex(e => e.Notify, "IX_STF_USERGROUPS_NOTIFY");

            entity.HasIndex(e => e.Teamid, "IX_STF_USERGROUPS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Alluser).HasColumnName("ALLUSER");
            entity.Property(e => e.Groupcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GROUPCODE");
            entity.Property(e => e.Groupname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.Notify).HasColumnName("NOTIFY");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Userid)
                .HasColumnType("text")
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<StfUsergroupsLine>(entity =>
        {
            entity.ToTable("STF_USERGROUPS_LINE");

            entity.HasIndex(e => e.Active, "IX_STF_USERGROUPS_LINE_ACTIVE");

            entity.HasIndex(e => e.Usergroupid, "IX_STF_USERGROUPS_LINE_USERGROUPID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Api)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("API");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Sendimg).HasColumnName("SENDIMG");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Usergroupid).HasColumnName("USERGROUPID");
        });

        modelBuilder.Entity<StfUsertoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STF_USER__3214EC27988B8E6D");

            entity.ToTable("STF_USERTOKEN");

            entity.HasIndex(e => e.Ttype, "STF_USERTOKEN_TTYPE");

            entity.HasIndex(e => e.Userid, "STF_USERTOKEN_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tokencode)
                .HasMaxLength(500)
                .HasColumnName("TOKENCODE");
            entity.Property(e => e.Ttype)
                .HasMaxLength(3)
                .HasColumnName("TTYPE");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Stockin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STOCKIN__3214EC276D19396E");

            entity.ToTable("STOCKIN");

            entity.HasIndex(e => e.Atdate, "STOCKIN_ATDATE");

            entity.HasIndex(e => e.ProductskuId, "STOCKIN_PRODUCTSKU_ID");

            entity.HasIndex(e => e.Stkcard, "STOCKIN_STKCARD");

            entity.HasIndex(e => e.Stktype, "STOCKIN_STKTYPE");

            entity.HasIndex(e => e.Storeid, "STOCKIN_STOREID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amtin).HasColumnName("AMTIN");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Invno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVNO");
            entity.Property(e => e.PriceId).HasColumnName("PRICE_ID");
            entity.Property(e => e.Priceall)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEALL");
            entity.Property(e => e.Pricerate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICERATE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Stkcard)
                .HasMaxLength(50)
                .HasColumnName("STKCARD");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Stockout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STOCKOUT__3214EC277160AA70");

            entity.ToTable("STOCKOUT");

            entity.HasIndex(e => e.ProductskuId, "STOCKOUT_PRODUCTSKU_ID");

            entity.HasIndex(e => e.Stkocard, "STOCKOUT_STKOCARD");

            entity.HasIndex(e => e.Stktype, "STOCKOUT_STKTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CurrStoreid).HasColumnName("CURR_STOREID");
            entity.Property(e => e.DestStoreaddr)
                .HasMaxLength(500)
                .HasColumnName("DEST_STOREADDR");
            entity.Property(e => e.DestStoreid).HasColumnName("DEST_STOREID");
            entity.Property(e => e.DestStorename)
                .HasMaxLength(100)
                .HasColumnName("DEST_STORENAME");
            entity.Property(e => e.PriceAll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE_ALL");
            entity.Property(e => e.PriceId).HasColumnName("PRICE_ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("REMARK");
            entity.Property(e => e.Stkocard)
                .HasMaxLength(50)
                .HasColumnName("STKOCARD");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STORE__3214EC27553E6E5C");

            entity.ToTable("STORE");

            entity.HasIndex(e => e.Areaid, "IX_STORE_AREAID");

            entity.HasIndex(e => e.Storegroupid, "IX_STORE_STOREGROUPID");

            entity.HasIndex(e => e.Storetypeid, "IX_STORE_STORETYPEID");

            entity.HasIndex(e => e.Stt, "IX_STORE_STT");

            entity.HasIndex(e => e.Storecode, "STORE_STORECODE");

            entity.HasIndex(e => e.Storename, "STORE_STORENAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Branchcode)
                .HasMaxLength(50)
                .HasColumnName("BRANCHCODE");
            entity.Property(e => e.Branchname)
                .HasMaxLength(250)
                .HasColumnName("BRANCHNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storedisplay)
                .HasMaxLength(300)
                .HasColumnName("STOREDISPLAY");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Storetypeid).HasColumnName("STORETYPEID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StoreLocation>(entity =>
        {
            entity.ToTable("STORE_LOCATION");

            entity.HasIndex(e => e.Gps, "IX_STORE_LOCATION_GPS");

            entity.HasIndex(e => e.Storeid, "IX_STORE_LOCATION_STOREID");

            entity.HasIndex(e => e.Stt, "IX_STORE_LOCATION_STT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Gps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GPS");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<StoreTarget>(entity =>
        {
            entity.ToTable("STORE_TARGET");

            entity.HasIndex(e => e.Atdate, "IX_STORE_TARGET_ATDATE");

            entity.HasIndex(e => e.Storeid, "IX_STORE_TARGET_STOREID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AchPerc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ACH_PERC");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Producttargetid).HasColumnName("PRODUCTTARGETID");
            entity.Property(e => e.StoreTarget1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("STORE_TARGET");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
        });

        modelBuilder.Entity<StoreTargetProduct>(entity =>
        {
            entity.ToTable("STORE_TARGET_PRODUCT");

            entity.HasIndex(e => e.Ptargetcode, "IX_STORE_TARGET_PRODUCT_PTARGETCODE");

            entity.HasIndex(e => e.Stt, "IX_STORE_TARGET_PRODUCT_STT");

            entity.HasIndex(e => e.Ptargetid, "IX_STORE_TARGET_PRODUCT_TARGETID");

            entity.HasIndex(e => e.Type, "IX_STORE_TARGET_PRODUCT_TYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ProductSaletarget)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PRODUCT_SALETARGET");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.PtargetSaletarget)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PTARGET_SALETARGET");
            entity.Property(e => e.Ptargetcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PTARGETCODE");
            entity.Property(e => e.Ptargetid).HasColumnName("PTARGETID");
            entity.Property(e => e.SkuSaletarget)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SKU_SALETARGET");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Storegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STOREGRO__3214EC274F43C07D");

            entity.ToTable("STOREGROUP");

            entity.HasIndex(e => e.Storegroupcode, "STOREGROUP_STOREGROUPCODE");

            entity.HasIndex(e => e.Storegroupname, "STOREGROUP_STOREGROUPNAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Storegroupcode)
                .HasMaxLength(50)
                .HasColumnName("STOREGROUPCODE");
            entity.Property(e => e.Storegroupname)
                .HasMaxLength(250)
                .HasColumnName("STOREGROUPNAME");
            entity.Property(e => e.Storetypeid).HasColumnName("STORETYPEID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Storestaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STORESTA__3214EC27985CA9E8");

            entity.ToTable("STORESTAFF");

            entity.HasIndex(e => e.Staffid, "STORESTAFF_STAFFID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Storetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STORETYP__3214EC270A0F6639");

            entity.ToTable("STORETYPE");

            entity.HasIndex(e => e.Storetypecode, "STORETYPE_STORETYPECODE");

            entity.HasIndex(e => e.Storetypename, "STORETYPE_STORETYPENAME");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Storetypecode)
                .HasMaxLength(50)
                .HasColumnName("STORETYPECODE");
            entity.Property(e => e.Storetypename)
                .HasMaxLength(250)
                .HasColumnName("STORETYPENAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<SysAccessLog>(entity =>
        {
            entity.ToTable("SYS_ACCESS_LOG");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Systemcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SYSTEMCODE");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<SysAppupdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_APPU__3214EC27291BCE05");

            entity.ToTable("SYS_APPUPDATE");

            entity.HasIndex(e => e.Appid, "SYS_APPUPDATE_APPID");

            entity.HasIndex(e => e.Versioncode, "SYS_APPUPDATE_VERSIONCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.Appurl)
                .HasColumnType("text")
                .HasColumnName("APPURL");
            entity.Property(e => e.Descurl)
                .HasColumnType("text")
                .HasColumnName("DESCURL");
            entity.Property(e => e.Versioncode)
                .HasMaxLength(20)
                .HasColumnName("VERSIONCODE");
        });

        modelBuilder.Entity<SysDevice>(entity =>
        {
            entity.ToTable("SYS_DEVICE");

            entity.HasIndex(e => e.Appid, "IX_SYS_DEVICE_APPID");

            entity.HasIndex(e => e.HwSerial, "IX_SYS_DEVICE_HW_SERIAL");

            entity.HasIndex(e => e.Uuid, "IX_SYS_DEVICE_UUID");

            entity.HasIndex(e => e.Id, "SYS_DEVICE_ID");

            entity.HasIndex(e => e.Userid, "SYS_DEVICE_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.HwSerial)
                .HasMaxLength(100)
                .HasColumnName("HW_SERIAL");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.PlatformVertion)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM_VERTION");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Uuid)
                .HasMaxLength(100)
                .HasColumnName("UUID");
        });

        modelBuilder.Entity<SysDeviceAtt>(entity =>
        {
            entity.ToTable("SYS_DEVICE_ATT");

            entity.HasIndex(e => e.ClientVersion, "IX_SYS_DEVICE_ATT_CLIENT_VERSION");

            entity.HasIndex(e => e.Empid, "IX_SYS_DEVICE_ATT_EMPID");

            entity.HasIndex(e => e.UpdateDate, "IX_SYS_DEVICE_ATT_UPDATE_DATE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClientVersion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLIENT_VERSION");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.Ram).HasColumnName("RAM");
            entity.Property(e => e.Sdk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SDK");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Version)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<SysEmailsentLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_EMAI__3214EC276288A470");

            entity.ToTable("SYS_EMAILSENT_LOG");

            entity.HasIndex(e => e.EmailForm, "SYS_EMAILSENT_LOG_EMAIL_FORM");

            entity.HasIndex(e => e.EmailTo, "SYS_EMAILSENT_LOG_EMAIL_TO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Body)
                .HasColumnType("text")
                .HasColumnName("BODY");
            entity.Property(e => e.EmailForm)
                .HasMaxLength(50)
                .HasColumnName("EMAIL_FORM");
            entity.Property(e => e.EmailTo)
                .HasMaxLength(50)
                .HasColumnName("EMAIL_TO");
            entity.Property(e => e.ErrorMsg)
                .HasColumnType("text")
                .HasColumnName("ERROR_MSG");
            entity.Property(e => e.Refid).HasColumnName("REFID");
            entity.Property(e => e.SendDate)
                .HasColumnType("datetime")
                .HasColumnName("SEND_DATE");
            entity.Property(e => e.Subj)
                .HasMaxLength(200)
                .HasColumnName("SUBJ");
        });

        modelBuilder.Entity<SysExceptionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_EXCE__3214EC273419B50B");

            entity.ToTable("SYS_EXCEPTION_LOG");

            entity.HasIndex(e => e.Logtime, "IX_SYS_EXCEPTION_LOG_LOGTIME");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("LOGTIME");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Stacktrace)
                .HasColumnType("text")
                .HasColumnName("STACKTRACE");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasColumnName("TARGET");
        });

        modelBuilder.Entity<SysFuncsett>(entity =>
        {
            entity.ToTable("SYS_FUNCSETT");

            entity.HasIndex(e => e.Active, "IX_SYS_FUNCSETT_ACTIVE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Func)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FUNC");
            entity.Property(e => e.Sett)
                .HasColumnType("text")
                .HasColumnName("SETT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<SysLogapi>(entity =>
        {
            entity.ToTable("SYS_LOGAPI");

            entity.HasIndex(e => e.Logtime, "IX_SYS_LOGAPI_LOGTIME");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Actionname)
                .HasColumnType("text")
                .HasColumnName("ACTIONNAME");
            entity.Property(e => e.Logowner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOGOWNER");
            entity.Property(e => e.Logtime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LOGTIME");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<SysMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_MENU__3214EC277A84D503");

            entity.ToTable("SYS_MENUS");

            entity.HasIndex(e => e.Active, "SYS_MENUS_ACTIVE");

            entity.HasIndex(e => e.Code, "SYS_MENUS_CODE");

            entity.HasIndex(e => e.Id, "SYS_MENUS_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DisplayTitle)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY_TITLE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("REMARK");
        });

        modelBuilder.Entity<SysMobileexceptionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_MOBI__3214EC27C38D8A4C");

            entity.ToTable("SYS_MOBILEEXCEPTION_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("LOGTIME");
            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("MSG");
            entity.Property(e => e.Os)
                .HasMaxLength(255)
                .HasColumnName("OS");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Sys)
                .HasMaxLength(255)
                .HasColumnName("SYS");
        });

        modelBuilder.Entity<SysMobileset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_MOBI__3214EC2782864090");

            entity.ToTable("SYS_MOBILESET");

            entity.HasIndex(e => e.Stt, "SYS_MOBILESET_STT");

            entity.HasIndex(e => e.Userid, "SYS_MOBILESET_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.SetKey)
                .HasMaxLength(50)
                .HasColumnName("SET_KEY");
            entity.Property(e => e.SetValueDec)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SET_VALUE_DEC");
            entity.Property(e => e.SetValueInt).HasColumnName("SET_VALUE_INT");
            entity.Property(e => e.SetValueStr)
                .HasMaxLength(200)
                .HasColumnName("SET_VALUE_STR");
            entity.Property(e => e.SetValueTime)
                .HasColumnType("datetime")
                .HasColumnName("SET_VALUE_TIME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SysNotify>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_NOTI__3214EC27C89F050B");

            entity.ToTable("SYS_NOTIFY");

            entity.HasIndex(e => e.Notifytype, "IX_SYS_NOTIFY_NOTIFYTYPE");

            entity.HasIndex(e => e.Sentdate, "IX_SYS_NOTIFY_SENTDATE");

            entity.HasIndex(e => e.Sent, "SYS_NOTIFY_SENT");

            entity.HasIndex(e => e.Stt, "SYS_NOTIFY_STT");

            entity.HasIndex(e => e.Userid, "SYS_NOTIFY_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Notifytype)
                .HasMaxLength(3)
                .HasColumnName("NOTIFYTYPE");
            entity.Property(e => e.Sent).HasColumnName("SENT");
            entity.Property(e => e.Sentdate)
                .HasColumnType("datetime")
                .HasColumnName("SENTDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(500)
                .HasColumnName("URL_IMG");
            entity.Property(e => e.UrlLink)
                .HasMaxLength(500)
                .HasColumnName("URL_LINK");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SysNotifyMessage>(entity =>
        {
            entity.ToTable("SYS_NOTIFY_MESSAGE");

            entity.HasIndex(e => e.Teamid, "IX_SYS_NOTIFY_MESSAGEP_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Lastsent)
                .HasColumnType("datetime")
                .HasColumnName("LASTSENT");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Notitype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOTITYPE");
            entity.Property(e => e.Sent).HasColumnName("SENT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<SysNotifyTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_NOTI__3214EC27A35C669B");

            entity.ToTable("SYS_NOTIFY_TIME");

            entity.HasIndex(e => e.Sent, "SYS_NOTIFY_TIME_SENT");

            entity.HasIndex(e => e.Stt, "SYS_NOTIFY_TIME_STT");

            entity.HasIndex(e => e.Teamid, "SYS_NOTIFY_TIME_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Sendtime)
                .HasColumnType("datetime")
                .HasColumnName("SENDTIME");
            entity.Property(e => e.Sent).HasColumnName("SENT");
            entity.Property(e => e.Sentdate)
                .HasColumnType("datetime")
                .HasColumnName("SENTDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("TITLE");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(500)
                .HasColumnName("URL_IMG");
            entity.Property(e => e.UrlLink)
                .HasMaxLength(500)
                .HasColumnName("URL_LINK");
        });

        modelBuilder.Entity<SysNotifyTime2>(entity =>
        {
            entity.ToTable("SYS_NOTIFY_TIME2");

            entity.HasIndex(e => e.Teamid, "IX_SYS_NOTIFY_TIME2_TEAMID");

            entity.HasIndex(e => e.Ttype, "IX_SYS_NOTIFY_TIME2_TTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Lastaction)
                .HasColumnType("datetime")
                .HasColumnName("LASTACTION");
            entity.Property(e => e.Notifyhour).HasColumnName("NOTIFYHOUR");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Ttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TTYPE");
        });

        modelBuilder.Entity<SysOtpBydevice>(entity =>
        {
            entity.ToTable("SYS_OTP_BYDEVICE");

            entity.HasIndex(e => e.Active, "IX_SYS_OTP_BYDEVICE_ACTIVE");

            entity.HasIndex(e => e.Empid, "IX_SYS_OTP_BYDEVICE_EMPID");

            entity.HasIndex(e => e.Tel, "IX_SYS_OTP_BYDEVICE_TEL");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.ActiveDate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.ObjectiveCode)
                .HasMaxLength(10)
                .HasColumnName("OBJECTIVE_CODE");
            entity.Property(e => e.Otp)
                .HasMaxLength(20)
                .HasColumnName("OTP");
            entity.Property(e => e.RequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("REQUEST_DATE");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<SysPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SYS_PERM__3214EC27ECEA4831");

            entity.ToTable("SYS_PERMISSION");

            entity.HasIndex(e => e.Empid, "SYS_PERMISSION_EMPID");

            entity.HasIndex(e => e.Stt, "SYS_PERMISSION_STT");

            entity.HasIndex(e => e.Systemcode, "SYS_PERMISSION_SYSTEMCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Func)
                .HasColumnType("text")
                .HasColumnName("FUNC");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Systemcode)
                .HasMaxLength(10)
                .HasColumnName("SYSTEMCODE");
        });

        modelBuilder.Entity<SysRealtimelocation>(entity =>
        {
            entity.ToTable("SYS_REALTIMELOCATION");

            entity.HasIndex(e => e.Atdate, "IX_SYS_REALTIMELOCATION_ATDATE");

            entity.HasIndex(e => e.Empid, "IX_SYS_REALTIMELOCATION_EMPID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Addr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.Atdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Lat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LNG");
        });

        modelBuilder.Entity<SysSmsotphi>(entity =>
        {
            entity.HasKey(e => e.Empid);

            entity.ToTable("SYS_SMSOTPHIS");

            entity.HasIndex(e => e.Active, "IX_SYS_SMSOTPHIS_ACTIVE");

            entity.HasIndex(e => e.Active, "SYS_SMSOTPHIS_ACTIVE");

            entity.HasIndex(e => e.Empid, "SYS_SMSOTPHIS_EMPID");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("EMPID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
        });

        modelBuilder.Entity<SysSmssent>(entity =>
        {
            entity.ToTable("SYS_SMSSENT");

            entity.HasIndex(e => e.Err, "IX_SYS_SMSSENT_ERR");

            entity.HasIndex(e => e.Sent, "IX_SYS_SMSSENT_SENT");

            entity.HasIndex(e => e.Telnumber, "IX_SYS_SMSSENT_TELNUMBER");

            entity.HasIndex(e => e.Err, "SYS_SMSSENT_ERR");

            entity.HasIndex(e => e.Id, "SYS_SMSSENT_ID");

            entity.HasIndex(e => e.Sent, "SYS_SMSSENT_SENT");

            entity.HasIndex(e => e.Telnumber, "SYS_SMSSENT_TELNUMBER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Err).HasColumnName("ERR");
            entity.Property(e => e.MessageTxt)
                .HasMaxLength(250)
                .HasColumnName("MESSAGE_TXT");
            entity.Property(e => e.Sent).HasColumnName("SENT");
            entity.Property(e => e.Smsid)
                .HasMaxLength(50)
                .HasColumnName("SMSID");
            entity.Property(e => e.Telnumber)
                .HasMaxLength(20)
                .HasColumnName("TELNUMBER");
        });

        modelBuilder.Entity<SysWinappregister>(entity =>
        {
            entity.ToTable("SYS_WINAPPREGISTER");

            entity.HasIndex(e => e.Activate, "IX_SYS_WINAPPREGISTER_ACTIVATE");

            entity.HasIndex(e => e.MacAddr, "IX_SYS_WINAPPREGISTER_MAC_ADDR");

            entity.HasIndex(e => e.SerialDisk, "IX_SYS_WINAPPREGISTER_SERIAL_DISK");

            entity.HasIndex(e => e.SerialMboard, "IX_SYS_WINAPPREGISTER_SERIAL_MBOARD");

            entity.HasIndex(e => e.Stt, "IX_SYS_WINAPPREGISTER_STT");

            entity.HasIndex(e => e.Syscode, "IX_SYS_WINAPPREGISTER_SYSCODE");

            entity.HasIndex(e => e.Userid, "IX_SYS_WINAPPREGISTER_USERID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Activate).HasColumnName("ACTIVATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Lastuse)
                .HasColumnType("datetime")
                .HasColumnName("LASTUSE");
            entity.Property(e => e.MacAddr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAC_ADDR");
            entity.Property(e => e.SerialDisk)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERIAL_DISK");
            entity.Property(e => e.SerialMboard)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERIAL_MBOARD");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Syscode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.UseCount).HasColumnName("USE_COUNT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<TestPermit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEST_PERMIT");

            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<Titlename>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TITLENAM__3214EC27A26ADD05");

            entity.ToTable("TITLENAME");

            entity.HasIndex(e => e.Stt, "DEPTCODE_STT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chi)
                .HasMaxLength(255)
                .HasColumnName("CHI");
            entity.Property(e => e.Eng)
                .HasMaxLength(255)
                .HasColumnName("ENG");
            entity.Property(e => e.Jap)
                .HasMaxLength(255)
                .HasColumnName("JAP");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tha)
                .HasMaxLength(255)
                .HasColumnName("THA");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UNIT__3214EC274AF96563");

            entity.ToTable("UNIT");

            entity.HasIndex(e => e.Unitcode, "UNIT_UNITCODE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Capacity)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("CAPACITY");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(19, 5)")
                .HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<ViewAreastaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_AREASTAFF");

            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewAtt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATT");

            entity.Property(e => e.CheckinGps)
                .HasMaxLength(100)
                .HasColumnName("CHECKIN_GPS");
            entity.Property(e => e.Checkinname)
                .HasMaxLength(100)
                .HasColumnName("CHECKINNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Leavetype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEAVETYPE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("REASON");
            entity.Property(e => e.Stamp)
                .HasColumnType("datetime")
                .HasColumnName("STAMP");
            entity.Property(e => e.Stamptype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STAMPTYPE");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewAttcheckinDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTCHECKIN_DAY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Stampdate)
                .HasColumnType("date")
                .HasColumnName("STAMPDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Wday)
                .HasMaxLength(30)
                .HasColumnName("WDAY");
            entity.Property(e => e.Wdayindex).HasColumnName("WDAYINDEX");
        });

        modelBuilder.Entity<ViewAttendancesumm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTENDANCESUMM");

            entity.Property(e => e.Branchname)
                .HasMaxLength(250)
                .HasColumnName("BRANCHNAME");
            entity.Property(e => e.Day).HasColumnName("DAY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Leavetype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEAVETYPE");
            entity.Property(e => e.Stamp)
                .HasColumnType("datetime")
                .HasColumnName("STAMP");
            entity.Property(e => e.Stampdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STAMPDATE");
            entity.Property(e => e.Stamptime)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STAMPTIME");
            entity.Property(e => e.Stamptype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STAMPTYPE");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewAttgoanywhere>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTGOANYWHERE");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Attime)
                .HasColumnType("datetime")
                .HasColumnName("ATTIME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Eventname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EVENTNAME");
            entity.Property(e => e.Eventtypeid).HasColumnName("EVENTTYPEID");
            entity.Property(e => e.Eventypename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EVENTYPENAME");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Gps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.StoreOrPlace)
                .HasMaxLength(250)
                .HasColumnName("STORE_OR_PLACE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Tag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewAttleave4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTLEAVE4");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Endleave)
                .HasColumnType("datetime")
                .HasColumnName("ENDLEAVE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Leavedays).HasColumnName("LEAVEDAYS");
            entity.Property(e => e.Startleave)
                .HasColumnType("datetime")
                .HasColumnName("STARTLEAVE");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewAttmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTMONTH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Stcount).HasColumnName("STCOUNT");
            entity.Property(e => e.Stm).HasColumnName("STM");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Sty).HasColumnName("STY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewAttmonthIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTMONTH_IO");

            entity.Property(e => e.Checkin).HasColumnName("CHECKIN");
            entity.Property(e => e.Checkout).HasColumnName("CHECKOUT");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Mdate).HasColumnName("MDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Ydate).HasColumnName("YDATE");
        });

        modelBuilder.Entity<ViewAttweekendhol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ATTWEEKENDHOL");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewBrand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_BRAND");

            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.SubbrandCode)
                .HasMaxLength(250)
                .HasColumnName("SUBBRAND_CODE");
            entity.Property(e => e.SubbrandName)
                .HasMaxLength(250)
                .HasColumnName("SUBBRAND_NAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewCnndatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CNNDATA");

            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cnnstatus)
                .HasMaxLength(3)
                .HasColumnName("CNNSTATUS");
            entity.Property(e => e.Cnntype)
                .HasMaxLength(3)
                .HasColumnName("CNNTYPE");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skucode)
                .HasMaxLength(150)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ViewComgroupmember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_COMGROUPMEMBERS");

            entity.Property(e => e.Deptcode)
                .HasMaxLength(50)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.Userdisplay)
                .HasMaxLength(255)
                .HasColumnName("USERDISPLAY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewCpnprodtarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CPNPRODTARGET");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.Display)
                .HasMaxLength(200)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Tag)
                .HasColumnType("text")
                .HasColumnName("TAG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewCpnprodtargetDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CPNPRODTARGET_DATA");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cpnstatusid).HasColumnName("CPNSTATUSID");
            entity.Property(e => e.Cpntype)
                .HasMaxLength(3)
                .HasColumnName("CPNTYPE");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Photoname)
                .HasMaxLength(50)
                .HasColumnName("PHOTONAME");
            entity.Property(e => e.Prodtargetid).HasColumnName("PRODTARGETID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Tghilight).HasColumnName("TGHILIGHT");
            entity.Property(e => e.Tgstatus).HasColumnName("TGSTATUS");
        });

        modelBuilder.Entity<ViewCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRM");

            entity.Property(e => e.Building)
                .HasMaxLength(200)
                .HasColumnName("BUILDING");
            entity.Property(e => e.Contdays)
                .HasMaxLength(100)
                .HasColumnName("CONTDAYS");
            entity.Property(e => e.Conttime).HasColumnName("CONTTIME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(20)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_NAME");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.GetProductFrom)
                .HasMaxLength(250)
                .HasColumnName("GET_PRODUCT_FROM");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(50)
                .HasColumnName("HOUSE_NO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Moo)
                .HasMaxLength(50)
                .HasColumnName("MOO");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(20)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_NAME");
            entity.Property(e => e.RefBirthdate)
                .HasColumnType("datetime")
                .HasColumnName("REF_BIRTHDATE");
            entity.Property(e => e.RefFirstname)
                .HasMaxLength(100)
                .HasColumnName("REF_FIRSTNAME");
            entity.Property(e => e.RefLastname)
                .HasMaxLength(100)
                .HasColumnName("REF_LASTNAME");
            entity.Property(e => e.RefMage).HasColumnName("REF_MAGE");
            entity.Property(e => e.RefYage).HasColumnName("REF_YAGE");
            entity.Property(e => e.Regisdate)
                .HasColumnType("datetime")
                .HasColumnName("REGISDATE");
            entity.Property(e => e.Regisgroup)
                .HasMaxLength(3)
                .HasColumnName("REGISGROUP");
            entity.Property(e => e.Relation).HasColumnName("RELATION");
            entity.Property(e => e.Road)
                .HasMaxLength(200)
                .HasColumnName("ROAD");
            entity.Property(e => e.Soi)
                .HasMaxLength(200)
                .HasColumnName("SOI");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(20)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.SubdistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_NAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<ViewCrmcontactTel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRMCONTACT_TELS");

            entity.Property(e => e.Dday).HasColumnName("DDAY");
            entity.Property(e => e.Dmonth).HasColumnName("DMONTH");
            entity.Property(e => e.Dtel)
                .HasMaxLength(4000)
                .HasColumnName("DTEL");
            entity.Property(e => e.Dyear).HasColumnName("DYEAR");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewCrmproductFback>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRMPRODUCT_FBACK");

            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductOth)
                .HasMaxLength(250)
                .HasColumnName("PRODUCT_OTH");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("REMARK");
        });

        modelBuilder.Entity<ViewCrmregi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRMREGIS");

            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Regisdate)
                .HasColumnType("datetime")
                .HasColumnName("REGISDATE");
            entity.Property(e => e.Regisgroup)
                .HasMaxLength(3)
                .HasColumnName("REGISGROUP");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<ViewCrmstore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRMSTORE");

            entity.Property(e => e.Branchcode)
                .HasMaxLength(50)
                .HasColumnName("BRANCHCODE");
            entity.Property(e => e.Branchname)
                .HasMaxLength(250)
                .HasColumnName("BRANCHNAME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewCrmtel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CRMTELS");

            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_CODE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Productid).HasColumnName("PRODUCTID");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Regisdate)
                .HasColumnType("datetime")
                .HasColumnName("REGISDATE");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("TEL");
        });

        modelBuilder.Entity<ViewDeviceinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEINFO");

            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Teamid)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewDeviceinfo2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEINFO2");

            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.PlatformVertion)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM_VERTION");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewDeviceinfostati>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEINFOSTATIS");

            entity.Property(e => e.Device)
                .HasMaxLength(200)
                .HasColumnName("DEVICE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Teamid)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Val).HasColumnName("VAL");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<ViewDeviceuserIsupdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEUSER_ISUPDATE");

            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastsign)
                .HasColumnType("datetime")
                .HasColumnName("LASTSIGN");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.PlatformVertion)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM_VERTION");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewDeviceuserNotupdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEUSER_NOTUPDATE");

            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastsign)
                .HasColumnType("datetime")
                .HasColumnName("LASTSIGN");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.PlatformVertion)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM_VERTION");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewDeviceuserlastupdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_DEVICEUSERLASTUPDATE");

            entity.Property(e => e.AppVersion)
                .HasMaxLength(50)
                .HasColumnName("APP_VERSION");
            entity.Property(e => e.Appid)
                .HasMaxLength(50)
                .HasColumnName("APPID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastsign)
                .HasColumnType("datetime")
                .HasColumnName("LASTSIGN");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(200)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.PlatformVertion)
                .HasMaxLength(50)
                .HasColumnName("PLATFORM_VERTION");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewEdoDocaccept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_EDO_DOCACCEPT");

            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Dcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCODE");
            entity.Property(e => e.Docstt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DOCSTT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcard)
                .HasMaxLength(255)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewEdoDocaccept2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_EDO_DOCACCEPT2");

            entity.Property(e => e.Dcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCODE");
            entity.Property(e => e.Docstt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DOCSTT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_EMPLOYEE");

            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(50)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcard)
                .HasMaxLength(255)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastworkdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTWORKDATE");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Startworkdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTWORKDATE");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewEmployee2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_EMPLOYEE2");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(50)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcard)
                .HasMaxLength(255)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastworkdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTWORKDATE");
            entity.Property(e => e.Posicode)
                .HasMaxLength(50)
                .HasColumnName("POSICODE");
            entity.Property(e => e.Posiname)
                .HasMaxLength(200)
                .HasColumnName("POSINAME");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Startworkdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTWORKDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewEmployeecont>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_EMPLOYEECONT");

            entity.Property(e => e.ApvDate)
                .HasColumnType("datetime")
                .HasColumnName("APV_DATE");
            entity.Property(e => e.ApvOtp)
                .HasMaxLength(20)
                .HasColumnName("APV_OTP");
            entity.Property(e => e.ContAt)
                .HasMaxLength(200)
                .HasColumnName("CONT_AT");
            entity.Property(e => e.ContNo)
                .HasMaxLength(50)
                .HasColumnName("CONT_NO");
            entity.Property(e => e.ContTime)
                .HasColumnType("datetime")
                .HasColumnName("CONT_TIME");
            entity.Property(e => e.ContenDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTEN_DATE");
            entity.Property(e => e.ContractorAddr)
                .HasColumnType("text")
                .HasColumnName("CONTRACTOR_ADDR");
            entity.Property(e => e.ContractorAge).HasColumnName("CONTRACTOR_AGE");
            entity.Property(e => e.ContstDate)
                .HasColumnType("datetime")
                .HasColumnName("CONTST_DATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Edostt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EDOSTT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Positionid).HasColumnName("POSITIONID");
            entity.Property(e => e.Positionname)
                .HasMaxLength(200)
                .HasColumnName("POSITIONNAME");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALARY");
            entity.Property(e => e.Senddate)
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tag)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TAG");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.WorkPromonth).HasColumnName("WORK_PROMONTH");
        });

        modelBuilder.Entity<ViewGroupline>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_GROUPLINE");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Alluser).HasColumnName("ALLUSER");
            entity.Property(e => e.Api)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("API");
            entity.Property(e => e.Groupcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GROUPCODE");
            entity.Property(e => e.Groupname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Notify).HasColumnName("NOTIFY");
            entity.Property(e => e.Sendimg).HasColumnName("SENDIMG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
        });

        modelBuilder.Entity<ViewHrrecruitAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_HRRECRUIT_ADDR");

            entity.Property(e => e.Addr)
                .HasColumnType("text")
                .HasColumnName("ADDR");
            entity.Property(e => e.Addrindex).HasColumnName("ADDRINDEX");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_NAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_NAME");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.SubdistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_NAME");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<ViewJqan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_JQANS");

            entity.Property(e => e.Anstext)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ANSTEXT");
            entity.Property(e => e.Boolvalue).HasColumnName("BOOLVALUE");
            entity.Property(e => e.ChoiceId).HasColumnName("CHOICE_ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Qid).HasColumnName("QID");
            entity.Property(e => e.Quest)
                .HasColumnType("text")
                .HasColumnName("QUEST");
            entity.Property(e => e.Textvalue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TEXTVALUE");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<ViewJqzan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_JQZANS");

            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcard)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCARD");
            entity.Property(e => e.Quizuser).HasColumnName("QUIZUSER");
            entity.Property(e => e.Zid).HasColumnName("ZID");
        });

        modelBuilder.Entity<ViewJqzansuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_JQZANSUSER");

            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcard)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCARD");
            entity.Property(e => e.Protype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROTYPE");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Utype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UTYPE");
        });

        modelBuilder.Entity<ViewJqzquest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_JQZQUEST");

            entity.Property(e => e.Aid).HasColumnName("AID");
            entity.Property(e => e.Anstext)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ANSTEXT");
            entity.Property(e => e.Aseq).HasColumnName("ASEQ");
            entity.Property(e => e.Atype).HasColumnName("ATYPE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Quest)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("QUEST");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.Zid).HasColumnName("ZID");
        });

        modelBuilder.Entity<ViewJsaacclog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_JSAACCLOG");

            entity.Property(e => e.Auth)
                .HasMaxLength(200)
                .HasColumnName("AUTH");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewMReceiptstoresku>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_M_RECEIPTSTORESKU");

            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
        });

        modelBuilder.Entity<ViewMobilelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_MOBILELOG");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid)
                .HasMaxLength(255)
                .HasColumnName("EMPID");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("LOGTIME");
            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("MSG");
            entity.Property(e => e.Os)
                .HasMaxLength(255)
                .HasColumnName("OS");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Syscode)
                .HasMaxLength(255)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewMobilelogErrorCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_MOBILELOG_ERROR_CRM");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid)
                .HasMaxLength(255)
                .HasColumnName("EMPID");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("LOGTIME");
            entity.Property(e => e.Msg)
                .HasColumnType("text")
                .HasColumnName("MSG");
            entity.Property(e => e.Os)
                .HasMaxLength(255)
                .HasColumnName("OS");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Syscode)
                .HasMaxLength(255)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewNewstockBal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_NEWSTOCK_BAL");

            entity.Property(e => e.Ain).HasColumnName("AIN");
            entity.Property(e => e.Aout).HasColumnName("AOUT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Prall)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PRALL");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
        });

        modelBuilder.Entity<ViewOft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT");

            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewOftAccSmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_ACC_SMONTH");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Scash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SCASH");
            entity.Property(e => e.Smt).HasColumnName("SMT");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewOftAccSmonth2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_ACC_SMONTH2");

            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Scash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SCASH");
            entity.Property(e => e.Smt).HasColumnName("SMT");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewOftDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_DAY");

            entity.Property(e => e.Allprice)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ALLPRICE");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DISC");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Runno)
                .HasMaxLength(100)
                .HasColumnName("RUNNO");
            entity.Property(e => e.Saleout).HasColumnName("SALEOUT");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Unitprice)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("UNITPRICE");
        });

        modelBuilder.Entity<ViewOftProdSmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_PROD_SMONTH");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.SAmt).HasColumnName("S_AMT");
            entity.Property(e => e.SApay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_APAY");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
        });

        modelBuilder.Entity<ViewOftProdSmonth2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_PROD_SMONTH2");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.SAmt).HasColumnName("S_AMT");
            entity.Property(e => e.SApay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_APAY");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewOftProdSmonthx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_PROD_SMONTHX");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.SAmt).HasColumnName("S_AMT");
            entity.Property(e => e.SApay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_APAY");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
        });

        modelBuilder.Entity<ViewOftSkuD2d>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_SKU_D2D");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.SPie).HasColumnName("S_PIE");
            entity.Property(e => e.SPrice)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_PRICE");
            entity.Property(e => e.SPriceunit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("S_PRICEUNIT");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewOftSkuD2dx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_SKU_D2DX");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.SPie).HasColumnName("S_PIE");
            entity.Property(e => e.SPrice)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_PRICE");
            entity.Property(e => e.SPriceunit)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_PRICEUNIT");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewOftStaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_STAFF");

            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.AmtPiece).HasColumnName("AMT_PIECE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamcode)
                .HasMaxLength(50)
                .HasColumnName("TEAMCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<ViewOftStaffSmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_STAFF_SMONTH");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Samt).HasColumnName("SAMT");
            entity.Property(e => e.Scash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SCASH");
            entity.Property(e => e.Sdis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SDIS");
            entity.Property(e => e.Spay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SPAY");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamcode)
                .HasMaxLength(50)
                .HasColumnName("TEAMCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<ViewOftStaffx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_STAFFX");

            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.AmtPiece).HasColumnName("AMT_PIECE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamcode)
                .HasMaxLength(50)
                .HasColumnName("TEAMCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<ViewOftStoreSmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_STORE_SMONTH");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SCash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_CASH");
            entity.Property(e => e.SDis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_DIS");
            entity.Property(e => e.SPie).HasColumnName("S_PIE");
            entity.Property(e => e.SPrice)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("S_PRICE");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewOftSupSmonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OFT_SUP_SMONTH");

            entity.Property(e => e.Atm).HasColumnName("ATM");
            entity.Property(e => e.Aty).HasColumnName("ATY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Samt).HasColumnName("SAMT");
            entity.Property(e => e.Scash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SCASH");
            entity.Property(e => e.Sdis)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SDIS");
            entity.Property(e => e.Spay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("SPAY");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamcode)
                .HasMaxLength(50)
                .HasColumnName("TEAMCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<ViewOo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OOS");

            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Bring).HasColumnName("BRING");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IvtstatusId).HasColumnName("IVTSTATUS_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.StoreId).HasColumnName("STORE_ID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewOos2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OOS2");

            entity.Property(e => e.Atmonth).HasColumnName("ATMONTH");
            entity.Property(e => e.Atyear).HasColumnName("ATYEAR");
            entity.Property(e => e.Bring).HasColumnName("BRING");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
        });

        modelBuilder.Entity<ViewPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_PERMISSION");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Func)
                .HasColumnType("text")
                .HasColumnName("FUNC");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Systemcode)
                .HasMaxLength(10)
                .HasColumnName("SYSTEMCODE");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_PRODUCTS");

            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Discontinued).HasColumnName("DISCONTINUED");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProducttypeId).HasColumnName("PRODUCTTYPE_ID");
            entity.Property(e => e.Producttypecode)
                .HasMaxLength(50)
                .HasColumnName("PRODUCTTYPECODE");
            entity.Property(e => e.Producttypename)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTTYPENAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ViewProductCompet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_PRODUCT_COMPET");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Tag)
                .HasColumnType("ntext")
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<ViewProductsSku>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_PRODUCTS_SKU");

            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Priceid).HasColumnName("PRICEID");
            entity.Property(e => e.ProductDetail)
                .HasColumnType("ntext")
                .HasColumnName("PRODUCT_DETAIL");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ViewProductskuBal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_PRODUCTSKU_BAL");

            entity.Property(e => e.Amtbal).HasColumnName("AMTBAL");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
        });

        modelBuilder.Entity<ViewRawOfftakeEuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_raw_offtake_euc");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.AreaStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AREA_STT");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.EmpStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMP_STT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Pay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PAY");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProdRemark)
                .HasMaxLength(255)
                .HasColumnName("PROD_REMARK");
            entity.Property(e => e.ProdStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROD_STT");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Realprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REALPRICE");
            entity.Property(e => e.ReceiptRemark)
                .HasMaxLength(255)
                .HasColumnName("RECEIPT_REMARK");
            entity.Property(e => e.ReceiptStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RECEIPT_STT");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.StoreStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STORE_STT");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewRealtimelocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_REALTIMELOCATION");

            entity.Property(e => e.Addr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LNG");
        });

        modelBuilder.Entity<ViewReceiptStaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECEIPT_STAFF");

            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.AmtPiece).HasColumnName("AMT_PIECE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Cash)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CASH");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewReceiptSumout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECEIPT_SUMOUT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Sumamtout).HasColumnName("SUMAMTOUT");
        });

        modelBuilder.Entity<ViewReceiptlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECEIPTLIST");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PAY");
            entity.Property(e => e.Realprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REALPRICE");
            entity.Property(e => e.Runno)
                .HasMaxLength(100)
                .HasColumnName("RUNNO");
            entity.Property(e => e.Salecount).HasColumnName("SALECOUNT");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewReceiptprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECEIPTPROD");

            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Runno)
                .HasMaxLength(100)
                .HasColumnName("RUNNO");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewReceptUserpcount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECEPT_USERPCOUNT");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Prodcount).HasColumnName("PRODCOUNT");
            entity.Property(e => e.RecDate)
                .HasColumnType("date")
                .HasColumnName("REC_DATE");
        });

        modelBuilder.Entity<ViewRecruit0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_RECRUIT0");

            entity.Property(e => e.ActionBy).HasColumnName("ACTION_BY");
            entity.Property(e => e.ActionByName)
                .HasMaxLength(253)
                .HasColumnName("ACTION_BY_NAME");
            entity.Property(e => e.ActionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTION_STATUS");
            entity.Property(e => e.Actiondate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIONDATE");
            entity.Property(e => e.Addr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDR");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.Child).HasColumnName("CHILD");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Dadage).HasColumnName("DADAGE");
            entity.Property(e => e.Dadjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DADJOB");
            entity.Property(e => e.Dadname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DADNAME");
            entity.Property(e => e.EduInst)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EDU_INST");
            entity.Property(e => e.EduLev)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EDU_LEV");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FNAME");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InterviewDate)
                .HasColumnType("datetime")
                .HasColumnName("INTERVIEW_DATE");
            entity.Property(e => e.InterviewRemark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INTERVIEW_REMARK");
            entity.Property(e => e.InterviewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INTERVIEW_STATUS");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LNAME");
            entity.Property(e => e.Marage).HasColumnName("MARAGE");
            entity.Property(e => e.Marjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MARJOB");
            entity.Property(e => e.Marname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MARNAME");
            entity.Property(e => e.Momage).HasColumnName("MOMAGE");
            entity.Property(e => e.Momjob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOMJOB");
            entity.Property(e => e.Momname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOMNAME");
            entity.Property(e => e.Nic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIC");
            entity.Property(e => e.Posiname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSINAME");
            entity.Property(e => e.Provname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVNAME");
            entity.Property(e => e.Readytowork)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("READYTOWORK");
            entity.Property(e => e.Refaddr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REFADDR");
            entity.Property(e => e.Refname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFNAME");
            entity.Property(e => e.Refrelat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFRELAT");
            entity.Property(e => e.Reftel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REFTEL");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEX");
            entity.Property(e => e.Skin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SKIN");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Tatoo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TATOO");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateByName)
                .HasMaxLength(253)
                .HasColumnName("UPDATE_BY_NAME");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.Workname1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME1");
            entity.Property(e => e.Workname2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("WORKNAME2");
            entity.Property(e => e.Workreason1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKREASON1");
            entity.Property(e => e.Workreason2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKREASON2");
            entity.Property(e => e.Worktime1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME1");
            entity.Property(e => e.Worktime2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORKTIME2");
        });

        modelBuilder.Entity<ViewSalary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SALARY");

            entity.Property(e => e.ActiveDate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.ContacttypeData)
                .HasMaxLength(255)
                .HasColumnName("CONTACTTYPE_DATA");
            entity.Property(e => e.DepartmentData)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMENT_DATA");
            entity.Property(e => e.DtlCap)
                .HasMaxLength(255)
                .HasColumnName("DTL_CAP");
            entity.Property(e => e.DtlId).HasColumnName("DTL_ID");
            entity.Property(e => e.DtlType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DTL_TYPE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(255)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.ExpenNetData)
                .HasMaxLength(255)
                .HasColumnName("EXPEN_NET_DATA");
            entity.Property(e => e.FullnameData)
                .HasMaxLength(255)
                .HasColumnName("FULLNAME_DATA");
            entity.Property(e => e.HeaderData)
                .HasMaxLength(255)
                .HasColumnName("HEADER_DATA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncomeCollectData)
                .HasMaxLength(255)
                .HasColumnName("INCOME_COLLECT_DATA");
            entity.Property(e => e.IncomeNetData)
                .HasMaxLength(255)
                .HasColumnName("INCOME_NET_DATA");
            entity.Property(e => e.MonthlyData)
                .HasMaxLength(255)
                .HasColumnName("MONTHLY_DATA");
            entity.Property(e => e.PaydateData)
                .HasMaxLength(255)
                .HasColumnName("PAYDATE_DATA");
            entity.Property(e => e.ResfunCollectData)
                .HasMaxLength(255)
                .HasColumnName("RESFUN_COLLECT_DATA");
            entity.Property(e => e.RoundData)
                .HasMaxLength(255)
                .HasColumnName("ROUND_DATA");
            entity.Property(e => e.SsCollectData)
                .HasMaxLength(255)
                .HasColumnName("SS_COLLECT_DATA");
            entity.Property(e => e.SubheaderData)
                .HasMaxLength(255)
                .HasColumnName("SUBHEADER_DATA");
            entity.Property(e => e.TaxCollectData)
                .HasMaxLength(255)
                .HasColumnName("TAX_COLLECT_DATA");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALUE");
            entity.Property(e => e.YearlyData)
                .HasMaxLength(255)
                .HasColumnName("YEARLY_DATA");
        });

        modelBuilder.Entity<ViewSalaryhi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SALARYHIS");

            entity.Property(e => e.Atmonth).HasColumnName("ATMONTH");
            entity.Property(e => e.Atyear).HasColumnName("ATYEAR");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Teamdesp)
                .HasColumnType("text")
                .HasColumnName("TEAMDESP");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<ViewSaleout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SALEOUT");

            entity.Property(e => e.Alldiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLDISCOUNT");
            entity.Property(e => e.Allpay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLPAY");
            entity.Property(e => e.Allrealprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLREALPRICE");
            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewSkupricesurvey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SKUPRICESURVEY");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Priceavg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEAVG");
            entity.Property(e => e.Pricemax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEMAX");
            entity.Property(e => e.Pricemin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEMIN");
            entity.Property(e => e.Pricetype).HasColumnName("PRICETYPE");
            entity.Property(e => e.PricetypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRICETYPE_NAME");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
        });

        modelBuilder.Entity<ViewStaffSup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STAFF_SUP");

            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Supcode)
                .HasMaxLength(50)
                .HasColumnName("SUPCODE");
            entity.Property(e => e.Supid).HasColumnName("SUPID");
            entity.Property(e => e.Supname)
                .HasMaxLength(232)
                .HasColumnName("SUPNAME");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewStaffarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STAFFAREA");

            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewStfactive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STFACTIVE");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewStfhilev>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STFHILEV");

            entity.Property(e => e.Deptcode)
                .HasMaxLength(50)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Deptname)
                .HasMaxLength(200)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empid).HasColumnName("EMPID");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Posicode)
                .HasMaxLength(50)
                .HasColumnName("POSICODE");
            entity.Property(e => e.Posiname)
                .HasMaxLength(200)
                .HasColumnName("POSINAME");
            entity.Property(e => e.Positionid).HasColumnName("POSITIONID");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewStfusergroupline>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STFUSERGROUPLINE");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Alluser).HasColumnName("ALLUSER");
            entity.Property(e => e.Api)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("API");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Groupcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GROUPCODE");
            entity.Property(e => e.Groupname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GROUPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Notify).HasColumnName("NOTIFY");
            entity.Property(e => e.Sendimg).HasColumnName("SENDIMG");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Userid)
                .HasColumnType("text")
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<ViewStockbal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STOCKBAL");

            entity.Property(e => e.Amtbal).HasColumnName("AMTBAL");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewStockbalDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STOCKBAL_DTL");

            entity.Property(e => e.Amtbal).HasColumnName("AMTBAL");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceId).HasColumnName("PRICE_ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
            entity.Property(e => e.ViewId).HasColumnName("VIEW_ID");
        });

        modelBuilder.Entity<ViewStockcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STOCKCARD");

            entity.Property(e => e.Frtcode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("FRTCODE");
            entity.Property(e => e.StockcardLast).HasColumnName("STOCKCARD_LAST");
            entity.Property(e => e.StockcardNew).HasColumnName("STOCKCARD_NEW");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewStockin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STOCKIN");

            entity.Property(e => e.Amtin).HasColumnName("AMTIN");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Invno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVNO");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceId).HasColumnName("PRICE_ID");
            entity.Property(e => e.Priceall)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICEALL");
            entity.Property(e => e.Pricerate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICERATE");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Skuqrcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUQRCODE");
            entity.Property(e => e.Stkcard)
                .HasMaxLength(50)
                .HasColumnName("STKCARD");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<ViewStockout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STOCKOUT");

            entity.Property(e => e.Amtout).HasColumnName("AMTOUT");
            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CurName)
                .HasMaxLength(250)
                .HasColumnName("CUR_NAME");
            entity.Property(e => e.CurrStoreid).HasColumnName("CURR_STOREID");
            entity.Property(e => e.DesName)
                .HasMaxLength(250)
                .HasColumnName("DES_NAME");
            entity.Property(e => e.DestStoreaddr)
                .HasMaxLength(500)
                .HasColumnName("DEST_STOREADDR");
            entity.Property(e => e.DestStoreid).HasColumnName("DEST_STOREID");
            entity.Property(e => e.DestStorename)
                .HasMaxLength(100)
                .HasColumnName("DEST_STORENAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PriceAll)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE_ALL");
            entity.Property(e => e.PriceId).HasColumnName("PRICE_ID");
            entity.Property(e => e.ProductskuId).HasColumnName("PRODUCTSKU_ID");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("REMARK");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skudisplay)
                .HasMaxLength(500)
                .HasColumnName("SKUDISPLAY");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Stkocard)
                .HasMaxLength(50)
                .HasColumnName("STKOCARD");
            entity.Property(e => e.Stktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STKTYPE");
            entity.Property(e => e.Unitcode)
                .HasMaxLength(20)
                .HasColumnName("UNITCODE");
            entity.Property(e => e.Unitid).HasColumnName("UNITID");
            entity.Property(e => e.Unitname)
                .HasMaxLength(255)
                .HasColumnName("UNITNAME");
        });

        modelBuilder.Entity<ViewStorelocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STORELOCATION");

            entity.Property(e => e.Gps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GPS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
        });

        modelBuilder.Entity<ViewStorerecept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STORERECEPT");

            entity.Property(e => e.Atdate)
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Pay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PAY");
            entity.Property(e => e.Realprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REALPRICE");
            entity.Property(e => e.Runno)
                .HasMaxLength(100)
                .HasColumnName("RUNNO");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewStorestaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STORESTAFF");

            entity.Property(e => e.Areacode)
                .HasMaxLength(50)
                .HasColumnName("AREACODE");
            entity.Property(e => e.Areaid).HasColumnName("AREAID");
            entity.Property(e => e.Areaname)
                .HasMaxLength(250)
                .HasColumnName("AREANAME");
            entity.Property(e => e.Branchcode)
                .HasMaxLength(50)
                .HasColumnName("BRANCHCODE");
            entity.Property(e => e.Branchname)
                .HasMaxLength(250)
                .HasColumnName("BRANCHNAME");
            entity.Property(e => e.Desp)
                .HasColumnType("text")
                .HasColumnName("DESP");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storegroupid).HasColumnName("STOREGROUPID");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Storetypeid).HasColumnName("STORETYPEID");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Teamid)
                .HasColumnType("text")
                .HasColumnName("TEAMID");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewStorestafflocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_STORESTAFFLOCATION");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Gps)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GPS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            entity.Property(e => e.Storecode)
                .HasMaxLength(50)
                .HasColumnName("STORECODE");
            entity.Property(e => e.Storeid).HasColumnName("STOREID");
            entity.Property(e => e.Storename)
                .HasMaxLength(250)
                .HasColumnName("STORENAME");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
        });

        modelBuilder.Entity<ViewSyscrmSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SYSCRM_SUMMARY");

            entity.Property(e => e.CreateDay)
                .HasColumnType("date")
                .HasColumnName("CREATE_DAY");
            entity.Property(e => e.DayDisplay)
                .HasMaxLength(30)
                .HasColumnName("DAY_DISPLAY");
            entity.Property(e => e.EmailCount).HasColumnName("EMAIL_COUNT");
            entity.Property(e => e.ErrorLog).HasColumnName("ERROR_LOG");
            entity.Property(e => e.Firsttime).HasColumnName("FIRSTTIME");
            entity.Property(e => e.Lasttime).HasColumnName("LASTTIME");
            entity.Property(e => e.RegisterCount).HasColumnName("REGISTER_COUNT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.TelCount).HasColumnName("TEL_COUNT");
        });

        modelBuilder.Entity<ViewSyscrmUsersumm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SYSCRM_USERSUMM");

            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.DayDisplay)
                .HasMaxLength(30)
                .HasColumnName("DAY_DISPLAY");
            entity.Property(e => e.Days)
                .HasColumnType("date")
                .HasColumnName("DAYS");
            entity.Property(e => e.EmailCount).HasColumnName("EMAIL_COUNT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(231)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RegisCount).HasColumnName("REGIS_COUNT");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.TelCount).HasColumnName("TEL_COUNT");
        });

        modelBuilder.Entity<ViewSysdeviceatt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_SYSDEVICEATT");

            entity.Property(e => e.ClientVersion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLIENT_VERSION");
            entity.Property(e => e.EmpActive).HasColumnName("EMP_ACTIVE");
            entity.Property(e => e.EmpStt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMP_STT");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Empname)
                .HasMaxLength(232)
                .HasColumnName("EMPNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.Platform)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PLATFORM");
            entity.Property(e => e.Ram).HasColumnName("RAM");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
            entity.Property(e => e.Version)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<ViewTeammenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_TEAMMENUS");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.DeptidsPermiss)
                .HasColumnType("text")
                .HasColumnName("DEPTIDS_PERMISS");
            entity.Property(e => e.Display)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.DisplayTitle)
                .HasMaxLength(100)
                .HasColumnName("DISPLAY_TITLE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewTeamsku>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_TEAMSKU");

            entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");
            entity.Property(e => e.Brandcode)
                .HasMaxLength(50)
                .HasColumnName("BRANDCODE");
            entity.Property(e => e.Brandname)
                .HasMaxLength(250)
                .HasColumnName("BRANDNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Productcode)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTCODE");
            entity.Property(e => e.Productname)
                .HasMaxLength(250)
                .HasColumnName("PRODUCTNAME");
            entity.Property(e => e.Skubarcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SKUBARCODE");
            entity.Property(e => e.Skucode)
                .HasMaxLength(50)
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuname)
                .HasMaxLength(250)
                .HasColumnName("SKUNAME");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<ViewThaicounty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_THAICOUNTY");

            entity.Property(e => e.DistrictCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_CODE");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DISTRICT_NAME");
            entity.Property(e => e.GeoId).HasColumnName("GEO_ID");
            entity.Property(e => e.GeoName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GEO_NAME");
            entity.Property(e => e.ProvinceCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_CODE");
            entity.Property(e => e.ProvinceName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROVINCE_NAME");
            entity.Property(e => e.SubdistrictCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_CODE");
            entity.Property(e => e.SubdistrictName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUBDISTRICT_NAME");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<ViewWinappregister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_WINAPPREGISTER");

            entity.Property(e => e.Activate).HasColumnName("ACTIVATE");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .HasColumnName("EMPCODE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Lastuse)
                .HasColumnType("datetime")
                .HasColumnName("LASTUSE");
            entity.Property(e => e.MacAddr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAC_ADDR");
            entity.Property(e => e.SerialDisk)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERIAL_DISK");
            entity.Property(e => e.SerialMboard)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERIAL_MBOARD");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Syscode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Teamid)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(100)
                .HasColumnName("TEAMNAME");
            entity.Property(e => e.Titlename)
                .HasMaxLength(30)
                .HasColumnName("TITLENAME");
            entity.Property(e => e.UseCount).HasColumnName("USE_COUNT");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<WebcMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WEBC_MEN__3214EC27A9F07237");

            entity.ToTable("WEBC_MENUS");

            entity.HasIndex(e => e.Syscode, "WEBC_MENUS_SYSCODE");

            entity.HasIndex(e => e.Teamid, "WEBC_MENUS_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Cssclass)
                .HasMaxLength(250)
                .HasColumnName("CSSCLASS");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("('1')")
                .HasColumnName("ENABLE");
            entity.Property(e => e.Menucode)
                .HasMaxLength(20)
                .HasColumnName("MENUCODE");
            entity.Property(e => e.Menuname)
                .HasMaxLength(250)
                .HasColumnName("MENUNAME");
            entity.Property(e => e.Mvcaction)
                .HasMaxLength(250)
                .HasColumnName("MVCACTION");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Syscode)
                .HasMaxLength(10)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .HasColumnName("URL");
            entity.Property(e => e.Visable)
                .IsRequired()
                .HasDefaultValueSql("('1')")
                .HasColumnName("VISABLE");
        });

        modelBuilder.Entity<WebcMenusPermiss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WEBC_MEN__3214EC278508E87E");

            entity.ToTable("WEBC_MENUS_PERMISS");

            entity.HasIndex(e => e.Menuid, "WEBC_MENUS_PERMISS_MENUID");

            entity.HasIndex(e => e.Syscode, "WEBC_MENUS_PERMISS_SYSCODE");

            entity.HasIndex(e => e.Teamid, "WEBC_MENUS_PERMISS_TEAMID");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.Syscode)
                .HasMaxLength(10)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        modelBuilder.Entity<WebcReportexp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WEBC_REP__3214EC27FCBDC60E");

            entity.ToTable("WEBC_REPORTEXP");

            entity.HasIndex(e => e.Priority, "WEBC_REPORTEXP_PRIORITY");

            entity.HasIndex(e => e.Syscode, "WEBC_REPORTEXP_SYSCODE");

            entity.HasIndex(e => e.Taskname, "WEBC_REPORTEXP_TASKNAME");

            entity.HasIndex(e => e.Tasktype, "WEBC_REPORTEXP_TASKTYPE");

            entity.HasIndex(e => e.Teamid, "WEBC_REPORTEXP_TEAMID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Accessdept)
                .HasColumnType("text")
                .HasColumnName("ACCESSDEPT");
            entity.Property(e => e.Accesslevel).HasColumnName("ACCESSLEVEL");
            entity.Property(e => e.Criteria)
                .HasMaxLength(500)
                .HasColumnName("CRITERIA");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Fileformat)
                .HasMaxLength(20)
                .HasColumnName("FILEFORMAT");
            entity.Property(e => e.Filenameformat)
                .HasMaxLength(50)
                .HasColumnName("FILENAMEFORMAT");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.Stt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("STT");
            entity.Property(e => e.Syscode)
                .HasMaxLength(10)
                .HasColumnName("SYSCODE");
            entity.Property(e => e.Taskdisplay)
                .HasMaxLength(200)
                .HasColumnName("TASKDISPLAY");
            entity.Property(e => e.Taskname)
                .HasMaxLength(200)
                .HasColumnName("TASKNAME");
            entity.Property(e => e.Tasktype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TASKTYPE");
            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
