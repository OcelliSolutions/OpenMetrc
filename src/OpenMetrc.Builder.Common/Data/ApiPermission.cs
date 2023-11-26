using System.ComponentModel.DataAnnotations;

namespace OpenMetrc.Builder.Common.Data;

//The API permissions are not stored on the credentials or on a token. They are managed in METRC at user key creation.
public enum ApiPermission
{
    [Display(Name = "Lookup Caregivers")] LookupCaregivers,

    [Display(Name = "Manage Employees")] ManageEmployees,

    #region Harvest

    [Display(Name = "View Harvests")] ViewHarvests,
    [Display(Name = "Manage Harvests")] ManageHarvests,

    [Display(Name = "Finish/Discontinue Harvests")]
    FinishDiscontinueHarvests,
    [Display(Name = "Discontinue Harvest Waste")]
    DiscontinueHarvestWaste,

    #endregion Harvest

    [Display(Name = "Manage Items")] ManageItems,

    [Display(Name = "Manage Locations")] ManageLocations,

    #region Package

    [Display(Name = "View Packages")] ViewPackages,

    [Display(Name = "Create/Submit/Discontinue Packages")]
    CreateSubmitDiscontinuePackages,

    [Display(Name = "Manage Packages Inventory")]
    ManagePackagesInventory,

    [Display(Name = "Manage Package Notes")]
    ManagePackageNotes,

    [Display(Name = "View Package Source Harvests")]
    ViewPackageSourceHarvests,

    #endregion Package

    #region Patient

    [Display(Name = "Manage Patients")] ManagePatients,
    [Display(Name = "Lookup Patients")] LookupPatients,
    [Display(Name = "Manage Patients Check Ins")] ManagePatientsCheckIns,

    #endregion Patient

    #region Plant

    [Display(Name = "Manage Plants")] ManagePlants,

    [Display(Name = "View Immature Plants")]
    ViewImmaturePlants,

    [Display(Name = "Manage Immature Plants")]
    ManageImmaturePlants,

    [Display(Name = "Manage Immature Plants Inventory")]
    ManageImmaturePlantsInventory,

    [Display(Name = "Destroy Immature Plants")]
    DestroyImmaturePlants,

    [Display(Name = "View Veg/Flower Plants")]
    ViewVegFlowerPlants,

    [Display(Name = "Manage Veg/Flower Plants Inventory")]
    ManageVegFlowerPlantsInventory,

    [Display(Name = "Destroy Veg/Flower Plants")]
    DestroyVegFlowerPlants,

    [Display(Name = "View/Manage Plants Additives")]
    ViewManagePlantsAdditives,

    [Display(Name = "Manage Plants Additives")]
    ManagePlantsAdditives,

    [Display(Name = "Manicure/Harvest Veg/Flower Plants")]
    ManicureHarvestVegFlowerPlants,

    [Display(Name = "Manage Plants Waste")]
    ManagePlantsWaste,

    [Display(Name= "View Plant")]
    ViewPlant,

    #endregion Plant

    #region Processing

    [Display(Name = "Manage Processing Job")] ManageProcessingJob,

    #endregion Processing

    #region Sale

    [Display(Name = "Sales Delivery")] SalesDelivery,
    [Display(Name = "Sales")] Sales,
    [Display(Name = "Retailer Delivery")] RetailerDelivery,

    #endregion Sale

    [Display(Name = "Manage Strains")] ManageStrains,

    #region Transfer

    [Display(Name = "Transfers")] Transfers,
    [Display(Name = "Transfer Templates")] TransferTemplates,

    #endregion Transfer

}