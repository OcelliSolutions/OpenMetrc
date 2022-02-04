﻿// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming

namespace OpenMetrc;

enum MetrcEndpoint
{
    delete_items_v1_id,
    delete_locations_v1_id,
    delete_patients_v1_id,
    delete_sales_v1_delivery_id,
    delete_sales_v1_receipts_id,
    delete_strains_v1_id,
    delete_transfers_v1_external_incoming_id,
    delete_transfers_v1_templates_id,
    get_employees_v1_,
    get_facilities_v1_,
    get_harvests_v1_active,
    get_harvests_v1_id,
    get_harvests_v1_inactive,
    get_harvests_v1_onhold,
    get_harvests_v1_waste_types,
    get_items_v1_active,
    get_items_v1_brands,
    get_items_v1_categories,
    get_items_v1_id,
    get_labtests_v1_results,
    get_labtests_v1_states,
    get_labtests_v1_types,
    get_locations_v1_active,
    get_locations_v1_id,
    get_locations_v1_types,
    get_packages_v1_active,
    get_packages_v1_adjust_reasons,
    get_packages_v1_id,
    get_packages_v1_inactive,
    get_packages_v1_label,
    get_packages_v1_onhold,
    get_packages_v1_types,
    get_patients_v1_active,
    get_patients_v1_id,
    get_patients_v1_statuses_patientLicenseNumber,
    get_plantbatches_v1_active,
    get_plantbatches_v1_id,
    get_plantbatches_v1_inactive,
    get_plantbatches_v1_types,
    get_plants_v1_additives,
    get_plants_v1_additives_types,
    get_plants_v1_flowering,
    get_plants_v1_growthphases,
    get_plants_v1_id,
    get_plants_v1_inactive,
    get_plants_v1_label,
    get_plants_v1_onhold,
    get_plants_v1_vegetative,
    get_plants_v1_waste_methods,
    get_plants_v1_waste_reasons,
    get_sales_v1_customertypes,
    get_sales_v1_deliveries_active,
    get_sales_v1_deliveries_inactive,
    get_sales_v1_delivery_id,
    get_sales_v1_delivery_returnreasons,
    get_sales_v1_receipts_active,
    get_sales_v1_receipts_id,
    get_sales_v1_receipts_inactive,
    get_sales_v1_transactions,
    get_sales_v1_transactions_salesDateStart_salesDateEnd,
    get_strains_v1_active,
    get_strains_v1_id,
    get_transfers_v1_delivery_id_packages,
    get_transfers_v1_delivery_id_packages_wholesale,
    get_transfers_v1_delivery_id_transporters,
    get_transfers_v1_delivery_id_transporters_details,
    get_transfers_v1_delivery_package_id_requiredlabtestbatches,
    get_transfers_v1_delivery_packages_states,
    get_transfers_v1_id_deliveries,
    get_transfers_v1_incoming,
    get_transfers_v1_outgoing,
    get_transfers_v1_rejected,
    get_transfers_v1_templates,
    get_transfers_v1_templates_delivery_id_packages,
    get_transfers_v1_templates_delivery_id_transporters,
    get_transfers_v1_templates_delivery_id_transporters_details,
    get_transfers_v1_templates_id_deliveries,
    get_transfers_v1_types,
    get_unitsofmeasure_v1_active,
    post_harvests_v1_create_packages,
    post_harvests_v1_create_packages_testing,
    post_harvests_v1_finish,
    post_harvests_v1_removewaste,
    post_harvests_v1_unfinish,
    post_items_v1_create,
    post_items_v1_update,
    post_labtests_v1_record,
    post_locations_v1_create,
    post_locations_v1_update,
    post_packages_v1_adjust,
    post_packages_v1_change_item,
    post_packages_v1_change_locations,
    post_packages_v1_create,
    post_packages_v1_create_plantings,
    post_packages_v1_create_testing,
    post_packages_v1_finish,
    post_packages_v1_remediate,
    post_packages_v1_unfinish,
    post_patients_v1_add,
    post_patients_v1_update,
    post_plantbatches_v1_additives,
    post_plantbatches_v1_changegrowthphase,
    post_plantbatches_v1_create_packages_frommotherplant,
    post_plantbatches_v1_createpackages,
    post_plantbatches_v1_createplantings,
    post_plantbatches_v1_destroy,
    post_plantbatches_v1_split,
    post_plants_v1_additives,
    post_plants_v1_additives_bylocation,
    post_plants_v1_changegrowthphases,
    post_plants_v1_create_plantbatch_packages,
    post_plants_v1_create_plantings,
    post_plants_v1_destroyplants,
    post_plants_v1_harvestplants,
    post_plants_v1_manicureplants,
    post_plants_v1_moveplants,
    post_sales_v1_deliveries,
    post_sales_v1_receipts,
    post_sales_v1_transactions_date,
    post_strains_v1_create,
    post_strains_v1_update,
    post_transfers_v1_external_incoming,
    post_transfers_v1_templates,
    put_harvests_v1_move,
    put_harvests_v1_rename,
    put_labtests_v1_labtestdocument,
    put_labtests_v1_results_release,
    put_packages_v1_change_note,
    put_plantbatches_v1_moveplantbatches,
    put_sales_v1_deliveries,
    put_sales_v1_deliveries_complete,
    put_sales_v1_receipts,
    put_sales_v1_transactions_date,
    put_transfers_v1_external_incoming,
    put_transfers_v1_templates
}

static class MetrcEndpointExtensions
{
    public static IEnumerable<string> GetStates(MetrcEndpoint endpoint) =>
        endpoint switch
        {
            MetrcEndpoint.delete_items_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.delete_locations_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.delete_patients_v1_id => new[] { "co", "la", "ma", "mt", "nv", "ok", "wv" },
            MetrcEndpoint.delete_sales_v1_delivery_id => new[] { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.delete_sales_v1_receipts_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.delete_strains_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.delete_transfers_v1_external_incoming_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.delete_transfers_v1_templates_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_employees_v1_ => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_facilities_v1_ => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_harvests_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_harvests_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_harvests_v1_inactive => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_harvests_v1_onhold => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_harvests_v1_waste_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_items_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_items_v1_brands => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_items_v1_categories => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_items_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_labtests_v1_results => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_labtests_v1_states => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_labtests_v1_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_locations_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_locations_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_locations_v1_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_adjust_reasons => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_inactive => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_label => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_onhold => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_packages_v1_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_patients_v1_active => new[] { "co", "la", "ma", "mt", "nv", "ok", "wv" },
            MetrcEndpoint.get_patients_v1_id => new[] { "co", "la", "ma", "mt", "nv", "ok", "wv" },
            MetrcEndpoint.get_patients_v1_statuses_patientLicenseNumber => new[]
                { "co", "dc", "md", "mi", "mo", "mt", "wv" },
            MetrcEndpoint.get_plantbatches_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plantbatches_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plantbatches_v1_inactive => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plantbatches_v1_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_additives => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_additives_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_flowering => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_growthphases => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_inactive => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_label => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_onhold => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_vegetative => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_waste_methods => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_plants_v1_waste_reasons => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_customertypes => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_deliveries_active => new[]
                { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.get_sales_v1_deliveries_inactive => new[]
                { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.get_sales_v1_delivery_id => new[] { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.get_sales_v1_delivery_returnreasons => new[]
                { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.get_sales_v1_receipts_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_receipts_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_receipts_inactive => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_transactions => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_sales_v1_transactions_salesDateStart_salesDateEnd => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_strains_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_strains_v1_id => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_id_packages => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_id_packages_wholesale => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_id_transporters => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_id_transporters_details => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_package_id_requiredlabtestbatches => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_delivery_packages_states => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_id_deliveries => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_incoming => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_outgoing => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_rejected => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_templates => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_templates_delivery_id_packages => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_templates_delivery_id_transporters_details => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_templates_id_deliveries => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_transfers_v1_types => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.get_unitsofmeasure_v1_active => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_harvests_v1_create_packages => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_harvests_v1_create_packages_testing => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_harvests_v1_finish => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_harvests_v1_removewaste => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_harvests_v1_unfinish => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_items_v1_create => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_items_v1_update => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_labtests_v1_record => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_locations_v1_create => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_locations_v1_update => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_adjust => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_change_item => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_change_locations => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_create => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_create_plantings => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_create_testing => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_finish => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_remediate => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_packages_v1_unfinish => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_patients_v1_add => new[] { "co", "la", "ma", "mt", "nv", "ok", "wv" },
            MetrcEndpoint.post_patients_v1_update => new[] { "co", "la", "ma", "mt", "nv", "ok", "wv" },
            MetrcEndpoint.post_plantbatches_v1_additives => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_changegrowthphase => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_create_packages_frommotherplant => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_createpackages => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_createplantings => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_destroy => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plantbatches_v1_split => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_additives => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_additives_bylocation => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_changegrowthphases => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_create_plantbatch_packages => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_create_plantings => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_destroyplants => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_harvestplants => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_manicureplants => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_plants_v1_moveplants => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_sales_v1_deliveries => new[] { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.post_sales_v1_receipts => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_sales_v1_transactions_date => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_strains_v1_create => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_strains_v1_update => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_transfers_v1_external_incoming => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.post_transfers_v1_templates => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_harvests_v1_move => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_harvests_v1_rename => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_labtests_v1_labtestdocument => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_labtests_v1_results_release => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_packages_v1_change_note => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_plantbatches_v1_moveplantbatches => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_sales_v1_deliveries => new[] { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.put_sales_v1_deliveries_complete => new[]
                { "co", "dc", "md", "ma", "mi", "mo", "mt", "nv", "or" },
            MetrcEndpoint.put_sales_v1_receipts => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_sales_v1_transactions_date => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_transfers_v1_external_incoming => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            MetrcEndpoint.put_transfers_v1_templates => new[]
                { "ak", "ca", "co", "dc", "la", "me", "md", "ma", "mi", "mo", "mt", "nv", "oh", "ok", "or", "wv" },
            _ => throw new ArgumentOutOfRangeException(nameof(endpoint), endpoint, null)
        };
}