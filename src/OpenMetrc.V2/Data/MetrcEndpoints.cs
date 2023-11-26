﻿// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace OpenMetrc;

enum MetrcEndpoint
{
    delete_harvests_v2_waste_id,
	delete_items_v2_brand_id,
	delete_items_v2_id,
	delete_locations_v2_id,
	delete_packages_v2_id,
	delete_patient_checkins_v2_id,
	delete_patients_v2_id,
	delete_plantbatches_v2,
	delete_plants_v2,
	delete_processing_v2_id,
	delete_processing_v2_jobtypes_id,
	delete_sales_v2_deliveries_id,
	delete_sales_v2_deliveries_retailer_id,
	delete_sales_v2_receipts_id,
	delete_strains_v2_id,
	delete_transfers_v2_external_incoming_id,
	delete_transfers_v2_templates_outgoing_id,
	get_caregivers_v2_status_caregiverLicenseNumber,
	get_employees_v2,
	get_facilities_v2,
	get_harvests_v2_active,
	get_harvests_v2_id,
	get_harvests_v2_inactive,
	get_harvests_v2_onhold,
	get_harvests_v2_waste,
	get_harvests_v2_waste_types,
	get_items_v2_active,
	get_items_v2_brands,
	get_items_v2_categories,
	get_items_v2_id,
	get_items_v2_inactive,
	get_items_v2_photo_id,
	get_labtests_v2_batches,
	get_labtests_v2_labtestdocument_id,
	get_labtests_v2_results,
	get_labtests_v2_states,
	get_labtests_v2_types,
	get_locations_v2_active,
	get_locations_v2_id,
	get_locations_v2_inactive,
	get_locations_v2_types,
	get_packages_v2_active,
	get_packages_v2_adjust_reasons,
	get_packages_v2_id,
	get_packages_v2_id_source_harvests,
	get_packages_v2_inactive,
	get_packages_v2_intransit,
	get_packages_v2_label,
	get_packages_v2_labsamples,
	get_packages_v2_onhold,
	get_packages_v2_types,
	get_patient_checkins_v2,
	get_patient_checkins_v2_locations,
	get_patients_v2_active,
	get_patients_v2_id,
	get_patients_v2_statuses_patientLicenseNumber,
	get_plantbatches_v2_active,
	get_plantbatches_v2_id,
	get_plantbatches_v2_inactive,
	get_plantbatches_v2_types,
	get_plantbatches_v2_waste_reasons,
	get_plants_v2_additives,
	get_plants_v2_additives_types,
	get_plants_v2_flowering,
	get_plants_v2_growthphases,
	get_plants_v2_id,
	get_plants_v2_inactive,
	get_plants_v2_label,
	get_plants_v2_onhold,
	get_plants_v2_vegetative,
	get_plants_v2_waste_methods_all,
	get_plants_v2_waste_reasons,
	get_processing_v2_active,
	get_processing_v2_id,
	get_processing_v2_inactive,
	get_processing_v2_jobtypes_active,
	get_processing_v2_jobtypes_attributes,
	get_processing_v2_jobtypes_categories,
	get_processing_v2_jobtypes_inactive,
	get_sales_v2_counties,
	get_sales_v2_customertypes,
	get_sales_v2_deliveries_active,
	get_sales_v2_deliveries_id,
	get_sales_v2_deliveries_inactive,
	get_sales_v2_deliveries_retailer_active,
	get_sales_v2_deliveries_retailer_id,
	get_sales_v2_deliveries_retailer_inactive,
	get_sales_v2_deliveries_returnreasons,
	get_sales_v2_patientregistration_locations,
	get_sales_v2_paymenttypes,
	get_sales_v2_receipts_active,
	get_sales_v2_receipts_id,
	get_sales_v2_receipts_inactive,
	get_strains_v2_active,
	get_strains_v2_id,
	get_strains_v2_inactive,
	get_tags_v2_package_available,
	get_tags_v2_plant_available,
	get_transfers_v2_deliveries_id_packages,
	get_transfers_v2_deliveries_id_packages_wholesale,
	get_transfers_v2_deliveries_id_transporters,
	get_transfers_v2_deliveries_id_transporters_details,
	get_transfers_v2_deliveries_package_id_requiredlabtestbatches,
	get_transfers_v2_deliveries_packages_states,
	get_transfers_v2_hub,
	get_transfers_v2_id_deliveries,
	get_transfers_v2_incoming,
	get_transfers_v2_outgoing,
	get_transfers_v2_rejected,
	get_transfers_v2_templates_outgoing,
	get_transfers_v2_templates_outgoing_deliveries_id_packages,
	get_transfers_v2_templates_outgoing_deliveries_id_transporters,
	get_transfers_v2_templates_outgoing_deliveries_id_transporters_details,
	get_transfers_v2_templates_outgoing_id_deliveries,
	get_transfers_v2_types,
	get_unitsofmeasure_v2_active,
	get_unitsofmeasure_v2_inactive,
	get_wastemethods_v2,
	post_harvests_v2_packages,
	post_harvests_v2_packages_testing,
	post_harvests_v2_waste,
	post_items_v2,
	post_items_v2_brand,
	post_items_v2_photo,
	post_labtests_v2_record,
	post_locations_v2,
	post_packages_v2,
	post_packages_v2_adjust,
	post_packages_v2_plantings,
	post_packages_v2_testing,
	post_patient_checkins_v2,
	post_patients_v2,
	post_plantbatches_v2_additives,
	post_plantbatches_v2_adjust,
	post_plantbatches_v2_growthphase,
	post_plantbatches_v2_packages,
	post_plantbatches_v2_packages_frommotherplant,
	post_plantbatches_v2_plantings,
	post_plantbatches_v2_split,
	post_plantbatches_v2_waste,
	post_plants_v2_additives,
	post_plants_v2_additives_bylocation,
	post_plants_v2_manicure,
	post_plants_v2_plantbatch_packages,
	post_plants_v2_plantings,
	post_plants_v2_waste,
	post_processing_v2_adjust,
	post_processing_v2_createpackages,
	post_processing_v2_jobtypes,
	post_processing_v2_start,
	post_sales_v2_deliveries,
	post_sales_v2_deliveries_retailer,
	post_sales_v2_deliveries_retailer_depart,
	post_sales_v2_deliveries_retailer_end,
	post_sales_v2_deliveries_retailer_restock,
	post_sales_v2_deliveries_retailer_sale,
	post_sales_v2_receipts,
	post_strains_v2,
	post_transfers_v2_external_incoming,
	post_transfers_v2_templates_outgoing,
	put_harvests_v2_finish,
	put_harvests_v2_location,
	put_harvests_v2_rename,
	put_harvests_v2_restore_harvestedplants,
	put_harvests_v2_unfinish,
	put_items_v2,
	put_items_v2_brand,
	put_labtests_v2_labtestdocument,
	put_labtests_v2_results_release,
	put_locations_v2,
	put_packages_v2_donation_flag,
	put_packages_v2_donation_unflag,
	put_packages_v2_finish,
	put_packages_v2_item,
	put_packages_v2_labtests_required,
	put_packages_v2_location,
	put_packages_v2_note,
	put_packages_v2_remediate,
	put_packages_v2_tradesample_flag,
	put_packages_v2_tradesample_unflag,
	put_packages_v2_unfinish,
	put_patient_checkins_v2,
	put_patients_v2,
	put_plantbatches_v2_location,
	put_plantbatches_v2_strain,
	put_plantbatches_v2_tag,
	put_plants_v2_growthphase,
	put_plants_v2_harvest,
	put_plants_v2_location,
	put_plants_v2_merge,
	put_plants_v2_split,
	put_plants_v2_strain,
	put_plants_v2_tag,
	put_processing_v2_finish,
	put_processing_v2_jobtypes,
	put_processing_v2_unfinish,
	put_sales_v2_deliveries,
	put_sales_v2_deliveries_complete,
	put_sales_v2_deliveries_hub,
	put_sales_v2_deliveries_hub_accept,
	put_sales_v2_deliveries_hub_depart,
	put_sales_v2_deliveries_hub_verifyID,
	put_sales_v2_deliveries_retailer,
	put_sales_v2_receipts,
	put_sales_v2_receipts_finalize,
	put_sales_v2_receipts_unfinalize,
	put_strains_v2,
	put_transfers_v2_external_incoming,
	put_transfers_v2_templates_outgoing
}

static class MetrcEndpointExtensions
{
    public static IEnumerable<string> GetAvailableStates() => 
        new List<string> {"ak",
			"al",
			"ar",
			"az",
			"ca",
			"co",
			"ct",
			"cz",
			"dc",
			"de",
			"fl",
			"ga",
			"gu",
			"hi",
			"ia",
			"id",
			"il",
			"in",
			"ks",
			"ky",
			"la",
			"ma",
			"md",
			"me",
			"mi",
			"mn",
			"mo",
			"ms",
			"mt",
			"nc",
			"nd",
			"ne",
			"nh",
			"nj",
			"nm",
			"nv",
			"ny",
			"oh",
			"ok",
			"or",
			"pa",
			"pr",
			"ri",
			"sc",
			"sd",
			"tn",
			"tx",
			"ut",
			"va",
			"vi",
			"vt",
			"wa",
			"wi",
			"wv",
			"wy"};

    public static IEnumerable<string> GetStates(MetrcEndpoint endpoint) => endpoint switch
    {
        MetrcEndpoint.delete_harvests_v2_waste_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_items_v2_brand_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_items_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_locations_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_packages_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_patient_checkins_v2_id => new[] {"mo"},
        MetrcEndpoint.delete_patients_v2_id => new[] {"co","gu","la","ma","ms","mt","nj","nv","ok","ri","sd","wv"},
        MetrcEndpoint.delete_plantbatches_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_plants_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_processing_v2_id => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.delete_processing_v2_jobtypes_id => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.delete_sales_v2_deliveries_id => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.delete_sales_v2_deliveries_retailer_id => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.delete_sales_v2_receipts_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_strains_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_transfers_v2_external_incoming_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.delete_transfers_v2_templates_outgoing_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_caregivers_v2_status_caregiverLicenseNumber => new[] {"gu","mn","ms","nj","ri","sd"},
        MetrcEndpoint.get_employees_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_facilities_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_onhold => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_waste => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_harvests_v2_waste_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_brands => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_categories => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_items_v2_photo_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_labtests_v2_batches => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_labtests_v2_labtestdocument_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_labtests_v2_results => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_labtests_v2_states => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_labtests_v2_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_locations_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_locations_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_locations_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_locations_v2_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_adjust_reasons => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_id_source_harvests => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_intransit => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_label => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_labsamples => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_onhold => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_packages_v2_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_patient_checkins_v2 => new[] {"mo"},
        MetrcEndpoint.get_patient_checkins_v2_locations => new[] {"mo"},
        MetrcEndpoint.get_patients_v2_active => new[] {"co","gu","la","ma","ms","mt","nj","nv","ok","ri","sd","wv"},
        MetrcEndpoint.get_patients_v2_id => new[] {"co","gu","la","ma","ms","mt","nj","nv","ok","ri","sd","wv"},
        MetrcEndpoint.get_patients_v2_statuses_patientLicenseNumber => new[] {"co","dc","gu","md","mi","mo","ms","mt","nj","ri","sd","wv"},
        MetrcEndpoint.get_plantbatches_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plantbatches_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plantbatches_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plantbatches_v2_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plantbatches_v2_waste_reasons => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_additives => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_additives_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_flowering => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_growthphases => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_label => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_onhold => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_vegetative => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_waste_methods_all => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_plants_v2_waste_reasons => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_processing_v2_active => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_id => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_inactive => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_jobtypes_active => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_jobtypes_attributes => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_jobtypes_categories => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_processing_v2_jobtypes_inactive => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.get_sales_v2_counties => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_customertypes => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_sales_v2_deliveries_active => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_id => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_inactive => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_retailer_active => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_retailer_id => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_retailer_inactive => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_deliveries_returnreasons => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_patientregistration_locations => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_sales_v2_paymenttypes => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.get_sales_v2_receipts_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_sales_v2_receipts_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_sales_v2_receipts_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_strains_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_strains_v2_id => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_strains_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_tags_v2_package_available => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_tags_v2_plant_available => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_id_packages => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_id_packages_wholesale => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_id_transporters => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_id_transporters_details => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_package_id_requiredlabtestbatches => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_deliveries_packages_states => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_hub => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_id_deliveries => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_incoming => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_outgoing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_rejected => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_templates_outgoing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_packages => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_templates_outgoing_deliveries_id_transporters_details => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_templates_outgoing_id_deliveries => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_transfers_v2_types => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_unitsofmeasure_v2_active => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_unitsofmeasure_v2_inactive => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.get_wastemethods_v2 => new[] {"gu","nj","ri"},
        MetrcEndpoint.post_harvests_v2_packages => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_harvests_v2_packages_testing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_harvests_v2_waste => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_items_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_items_v2_brand => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_items_v2_photo => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_labtests_v2_record => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_locations_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_packages_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_packages_v2_adjust => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_packages_v2_plantings => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_packages_v2_testing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_patient_checkins_v2 => new[] {"mo"},
        MetrcEndpoint.post_patients_v2 => new[] {"co","gu","la","ma","ms","mt","nj","nv","ok","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_additives => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_adjust => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_growthphase => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_packages => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_packages_frommotherplant => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_plantings => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_split => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plantbatches_v2_waste => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_additives => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_additives_bylocation => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_manicure => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_plantbatch_packages => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_plantings => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_plants_v2_waste => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_processing_v2_adjust => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.post_processing_v2_createpackages => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.post_processing_v2_jobtypes => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.post_processing_v2_start => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.post_sales_v2_deliveries => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_deliveries_retailer => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_deliveries_retailer_depart => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_deliveries_retailer_end => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_deliveries_retailer_restock => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_deliveries_retailer_sale => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.post_sales_v2_receipts => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_strains_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_transfers_v2_external_incoming => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.post_transfers_v2_templates_outgoing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_harvests_v2_finish => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_harvests_v2_location => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_harvests_v2_rename => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_harvests_v2_restore_harvestedplants => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_harvests_v2_unfinish => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_items_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_items_v2_brand => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_labtests_v2_labtestdocument => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_labtests_v2_results_release => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_locations_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_donation_flag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_donation_unflag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_finish => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_item => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_labtests_required => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_location => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_note => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_remediate => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_tradesample_flag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_tradesample_unflag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_packages_v2_unfinish => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_patient_checkins_v2 => new[] {"mo"},
        MetrcEndpoint.put_patients_v2 => new[] {"co","gu","la","ma","ms","mt","nj","nv","ok","ri","sd","wv"},
        MetrcEndpoint.put_plantbatches_v2_location => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plantbatches_v2_strain => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plantbatches_v2_tag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_growthphase => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_harvest => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_location => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_merge => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_split => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_strain => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_plants_v2_tag => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_processing_v2_finish => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.put_processing_v2_jobtypes => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.put_processing_v2_unfinish => new[] {"gu","nj","or","ri"},
        MetrcEndpoint.put_sales_v2_deliveries => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.put_sales_v2_deliveries_complete => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.put_sales_v2_deliveries_hub => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.put_sales_v2_deliveries_hub_accept => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_sales_v2_deliveries_hub_depart => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_sales_v2_deliveries_hub_verifyID => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_sales_v2_deliveries_retailer => new[] {"ca","co","dc","gu","ma","md","me","mi","mo","ms","mt","nj","nv","or","ri","sd"},
        MetrcEndpoint.put_sales_v2_receipts => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_sales_v2_receipts_finalize => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_sales_v2_receipts_unfinalize => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_strains_v2 => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mn","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_transfers_v2_external_incoming => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        MetrcEndpoint.put_transfers_v2_templates_outgoing => new[] {"ca","co","dc","gu","la","ma","md","me","mi","mo","ms","mt","nj","nv","oh","ok","or","ri","sd","wv"},
        _ => throw new ArgumentOutOfRangeException(nameof(endpoint), endpoint, null)
    };
}