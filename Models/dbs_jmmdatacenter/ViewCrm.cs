using System;
using System.Collections.Generic;

namespace jaruernCore.Models.dbs_jmmdatacenter;

public partial class ViewCrm
{
    public Guid? Teamid { get; set; }

    public Guid Id { get; set; }

    public DateTime? Regisdate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Regisgroup { get; set; }

    public string? RefFirstname { get; set; }

    public string? RefLastname { get; set; }

    public DateTime? RefBirthdate { get; set; }

    public int? RefYage { get; set; }

    public int? RefMage { get; set; }

    public DateTime? CreateDate { get; set; }

    public Guid? Storeid { get; set; }

    public int? Relation { get; set; }

    public string? Contdays { get; set; }

    public int? Conttime { get; set; }

    public string? GetProductFrom { get; set; }

    public string? HouseNo { get; set; }

    public string? Moo { get; set; }

    public string? Building { get; set; }

    public string? Soi { get; set; }

    public string? Road { get; set; }

    public string? SubdistrictCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? ProvinceCode { get; set; }

    public string? Zipcode { get; set; }

    public string? Display { get; set; }

    public string? SubdistrictName { get; set; }

    public string? DistrictName { get; set; }

    public string? ProvinceName { get; set; }
}
