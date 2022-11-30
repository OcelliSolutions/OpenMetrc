# METRC State &amp; Endpoint Coverage

The table below details all of the states that METRC is deployed into. Not every state has every endpoint (or section for that matter). This is generated automatically via scraping scripts. 
All endpoints should be mapped automatically in the NuGet package and OpenApi docs.

| **CaregiversStatus** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| --- |  --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| get_caregivers_v1_status_caregiverLicenseNumber |  |  |  |  |  |  |  |  |  |  | x |  | x |  | x |  |  |  |  | x | x |  |
| **Employees** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_employees_v1_ | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| **Facilities** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_facilities_v1_ | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Harvests** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_harvests_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v1_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v1_onhold | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v1_waste_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v1_create_packages | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v1_create_packages_testing | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v1_finish | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v1_removewaste | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v1_unfinish | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v1_move | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v1_rename | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Items** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_items_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_brands | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_categories | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v1_photo_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v1_create | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v1_photo | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v1_update | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **LabTests** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_labtests_v1_results | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v1_states | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v1_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_labtests_v1_record | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_labtests_v1_labtestdocument | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_labtests_v1_results_release | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Locations** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_locations_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v1_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_locations_v1_create | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_locations_v1_update | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Packages** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_packages_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_adjust_reasons | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_label | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_onhold | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v1_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_adjust | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_change_item | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_change_locations | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_create | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_create_plantings | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_create_testing | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_finish | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_remediate | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v1_unfinish | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v1_change_note | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Patients** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_patients_v1_id |  | x |  | x |  | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| get_patients_v1_active |  | x |  | x |  | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| get_patients_v1_id |  | x |  | x |  | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| post_patients_v1_add |  | x |  | x |  | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| post_patients_v1_update |  | x |  | x |  | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| **PatientsStatus** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_patients_v1_statuses_patientLicenseNumber |  |  |  | x | x |  |  | x |  | x |  | x | x | x | x |  |  |  |  | x | x | x |
| **PlantBatches** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_plantbatches_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v1_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v1_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_additives | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_changegrowthphase | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_create_packages_frommotherplant | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_createpackages | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_createplantings | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_destroy | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v1_split | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plantbatches_v1_moveplantbatches | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Plants** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_plants_v1_additives | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_additives_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_flowering | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_growthphases | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_label | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_onhold | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_vegetative | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_waste_methods_all | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v1_waste_reasons | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_additives | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_additives_bylocation | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_changegrowthphases | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_create_plantbatch_packages | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_create_plantings | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_destroyplants | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_harvestplants | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_manicureplants | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v1_moveplants | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **ProcessingJob** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_processing_v1_id |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| delete_processing_v1_jobtypes_id |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_active |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_id |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_inactive |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_jobtypes_active |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_jobtypes_attributes |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_jobtypes_categories |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| get_processing_v1_jobtypes_inactive |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| post_processing_v1_adjust |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| post_processing_v1_createpackages |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| post_processing_v1_jobtypes |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| post_processing_v1_start |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| put_processing_v1_finish |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| put_processing_v1_jobtypes |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| put_processing_v1_unfinish |  |  |  |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
| **Sales** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_sales_v1_delivery_id |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| delete_sales_v1_receipts_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_customertypes | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_deliveries_active |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v1_deliveries_inactive |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v1_delivery_id |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v1_delivery_returnreasons |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v1_patientregistration_locations | x | x |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_receipts_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_receipts_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_receipts_inactive | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_transactions | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v1_transactions_salesDateStart_salesDateEnd | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_sales_v1_deliveries |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v1_receipts | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_sales_v1_transactions_date | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v1_deliveries |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v1_deliveries_complete |  | x |  | x | x |  | x | x |  | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v1_receipts | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v1_transactions_date | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Strains** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_strains_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_strains_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_strains_v1_id | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_strains_v1_create | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_strains_v1_update | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Transfers** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_transfers_v1_external_incoming_id | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| delete_transfers_v1_templates_id | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_id_packages | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_id_packages_wholesale | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_id_transporters | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_id_transporters_details | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_package_id_requiredlabtestbatches | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_delivery_packages_states | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_id_deliveries | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_incoming | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_outgoing | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_rejected | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_templates | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_templates_delivery_id_packages | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_templates_delivery_id_transporters | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_templates_delivery_id_transporters_details | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_templates_id_deliveries | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v1_types | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_transfers_v1_external_incoming | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| post_transfers_v1_templates | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| put_transfers_v1_external_incoming | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| put_transfers_v1_templates | x | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| **UnitsOfMeasure** | **AK** | **AZ** | **CA** | **CO** | **DC** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_unitsofmeasure_v1_active | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
