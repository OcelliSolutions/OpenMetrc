# METRC State &amp; Endpoint Coverage

The table below details all of the states that METRC is deployed into. Not every state has every endpoint (or section for that matter). This is generated automatically via scraping scripts. 
All endpoints should be mapped automatically in the NuGet package and OpenApi docs.

| **CaregiversStatus** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| --- |  --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| get_caregivers_v2_status_caregiverLicenseNumber |  |  |  |  | x |  |  |  |  |  | x |  | x |  | x |  |  |  |  | x | x |  |
| **Employees** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_employees_v2 |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| **Facilities** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_facilities_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Harvests** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_harvests_v2_waste_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_onhold |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_waste |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_harvests_v2_waste_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v2_packages |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v2_packages_testing |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_harvests_v2_waste |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v2_finish |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v2_location |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v2_rename |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v2_restore_harvestedplants |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_harvests_v2_unfinish |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Items** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_items_v2_brand_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| delete_items_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_brands |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_categories |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_items_v2_photo_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v2_brand |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_items_v2_photo |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_items_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_items_v2_brand |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **LabTests** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_labtests_v2_batches |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v2_labtestdocument_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v2_results |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v2_states |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_labtests_v2_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_labtests_v2_record |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_labtests_v2_labtestdocument |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_labtests_v2_results_release |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Locations** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_locations_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_locations_v2_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_locations_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_locations_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Packages** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_packages_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_adjust_reasons |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_id_source_harvests |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_intransit |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_label |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_labsamples |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_onhold |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_packages_v2_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v2_adjust |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v2_plantings |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_packages_v2_testing |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_adjust |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_donation_flag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_donation_unflag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_finish |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_item |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_labtests_required |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_location |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_note |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_remediate |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_tradesample_flag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_tradesample_unflag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_unfinish |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_packages_v2_usebydate |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **PatientCheckIns** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_patient-checkins_v2_id |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  |  |  |  |  |  |  |
| get_patient-checkins_v2 |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  |  |  |  |  |  |  |
| get_patient-checkins_v2_locations |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  |  |  |  |  |  |  |
| post_patient-checkins_v2 |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  |  |  |  |  |  |  |
| put_patient-checkins_v2 |  |  |  |  |  |  |  |  |  |  |  | x |  |  |  |  |  |  |  |  |  |  |
| **Patients** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_patients_v2_id |  |  | x |  | x | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| get_patients_v2_active |  |  | x |  | x | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| get_patients_v2_id |  |  | x |  | x | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| post_patients_v2 |  |  | x |  | x | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| put_patients_v2 |  |  | x |  | x | x | x |  |  |  |  |  | x | x | x | x |  | x |  | x | x | x |
| **PatientsStatus** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_patients_v2_statuses_patientLicenseNumber |  |  | x | x | x |  |  | x |  | x |  | x | x | x | x |  |  |  |  | x | x | x |
| **PlantBatches** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_plantbatches_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v2_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plantbatches_v2_waste_reasons |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_additives |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_adjust |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_growthphase |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_packages |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_packages_frommotherplant |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_plantings |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_split |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plantbatches_v2_waste |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plantbatches_v2_location |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plantbatches_v2_strain |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plantbatches_v2_tag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Plants** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_plants_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_additives |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_additives_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_flowering |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_growthphases |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_label |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_onhold |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_vegetative |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_waste_methods_all |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_plants_v2_waste_reasons |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_additives |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_additives_bylocation |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_manicure |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_plantbatch_packages |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_plantings |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_plants_v2_waste |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_growthphase |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_harvest |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_location |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_merge |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_split |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_strain |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_plants_v2_tag |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **ProcessingJob** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_processing_v2_id |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| delete_processing_v2_jobtypes_id |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_active |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_id |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_inactive |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_jobtypes_active |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_jobtypes_attributes |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_jobtypes_categories |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| get_processing_v2_jobtypes_inactive |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| post_processing_v2_adjust |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| post_processing_v2_createpackages |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| post_processing_v2_jobtypes |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| post_processing_v2_start |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| put_processing_v2_finish |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| put_processing_v2_jobtypes |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| put_processing_v2_unfinish |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  | x | x |  |  |
| **Sales** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_sales_v2_deliveries_id |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| delete_sales_v2_deliveries_retailer_id |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| delete_sales_v2_receipts_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_counties |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_customertypes |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_deliveries_active |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_id |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_inactive |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_retailer_active |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_retailer_id |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_retailer_inactive |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_deliveries_returnreasons |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_patientregistration_locations |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_paymenttypes |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| get_sales_v2_receipts_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_receipts_external_externalNumber |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_receipts_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_sales_v2_receipts_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_sales_v2_deliveries |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_deliveries_retailer |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_deliveries_retailer_depart |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_deliveries_retailer_end |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_deliveries_retailer_restock |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_deliveries_retailer_sale |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| post_sales_v2_receipts |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_deliveries |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v2_deliveries_complete |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v2_deliveries_hub |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v2_deliveries_hub_accept |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_deliveries_hub_depart |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_deliveries_hub_verifyID |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_deliveries_retailer |  | x | x | x | x |  | x | x | x | x |  | x | x | x | x | x |  |  | x | x | x |  |
| put_sales_v2_receipts |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_receipts_finalize |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_sales_v2_receipts_unfinalize |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Strains** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_strains_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_strains_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_strains_v2_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_strains_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_strains_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_strains_v2 |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Tags** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_tags_v2_package_available |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_tags_v2_plant_available |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **Transfers** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_transfers_v2_external_incoming_id |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| delete_transfers_v2_templates_outgoing_id |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_id_packages |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_id_packages_wholesale |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_id_transporters |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_id_transporters_details |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_package_id_requiredlabtestbatches |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_deliveries_packages_states |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_hub |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_id_deliveries |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_incoming |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_outgoing |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_rejected |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_templates_outgoing |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_templates_outgoing_deliveries_id_packages |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_templates_outgoing_deliveries_id_transporters |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_templates_outgoing_deliveries_id_transporters_details |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_templates_outgoing_id_deliveries |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transfers_v2_types |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_transfers_v2_external_incoming |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| post_transfers_v2_templates_outgoing |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| put_transfers_v2_external_incoming |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| put_transfers_v2_templates_outgoing |  | x | x | x | x | x | x | x | x | x |  | x | x | x | x | x | x | x | x | x | x | x |
| **Transporters** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| delete_transporters_v2_drivers_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| delete_transporters_v2_vehicles_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transporters_v2_drivers |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transporters_v2_drivers_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transporters_v2_vehicles |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_transporters_v2_vehicles_id |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_transporters_v2_drivers |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| post_transporters_v2_vehicles |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_transporters_v2_drivers |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| put_transporters_v2_vehicles |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **UnitsOfMeasure** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_unitsofmeasure_v2_active |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| get_unitsofmeasure_v2_inactive |  | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x | x |
| **WasteMethods** | **AK** | **CA** | **CO** | **DC** | **GU** | **LA** | **MA** | **MD** | **ME** | **MI** | **MN** | **MO** | **MS** | **MT** | **NJ** | **NV** | **OH** | **OK** | **OR** | **RI** | **SD** | **WV** |
| get_wastemethods_v2 |  |  |  |  | x |  |  |  |  |  |  |  |  |  | x |  |  |  |  | x |  |  |
