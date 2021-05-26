import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS, HttpClient } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngularMaterialModule } from './angular-material.module';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

//Menus
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { MaintenanceSideNavigation } from './maintenance-nav-menu/maintenance-nav-menu.component';

//people components
import { PeopleComponent } from './people/people.component';
import { PersonEditComponent } from './people/person-edit.component';
import { PersonAddressesComponent } from './people/person-addresses.component';
import { PersonAddressEditComponent } from './people/person-address-edit.component';
import { PersonCompanyAddressComponent } from './people/person-company-address';

//meeting components
import { MeetingsComponent } from './meetings/meetings.component';
import { MeetingEditComponent } from './meetings/meeting-edit.component';

//session components
import { SessionsComponent } from './sessions/sessions.component'; 
import { SessionEditComponent } from './sessions/session-edit.component';

//speaker components
import { SpeakersComponent } from './speakers/speakers.component';
import { SpeakerEditComponent } from './speakers/speaker-edit.component';

//exhibitor components
import { ExhibitorsComponent } from './exhibitors/exhibitors.component';
import { ExhibitorEditComponent } from './exhibitors/exhibitor-edit.component';
import { ExhibitorNoteComponent } from './exhibitors/exhibitor-notes.component';
import { ExhibitorNoteEditComponent } from './exhibitors/exhibitor-notes-edit.component';
import { MaintenanceComponent } from './maintenance/maintenance.component';
import { ReportsComponent } from './reports/reports.component';

//Companies Components
import { CompaniesComponent } from './companies/companies.component';
import { CompanyEditComponent } from './companies/company-edit-component';
import { CompanyAddressesComponent } from './companies/company-addresses.component';
import { CompanyAddressEditComponent } from './companies/company-address-edit.component';
import { CompanyEmailComponent } from './companies/company-email-component';
import { CompanyEmailEditComponent } from './companies/company-email-edit.component';
import { CompanyNoteComponent } from './companies/company-notes-component';
import { CompanyNoteEditComponent } from './companies/company-notes-edit.component';
import { CompanyPeopleComponent } from './companies/company-people-component';
import { CompanyExhibitorsComponent } from './companies/company-exhibitors-component';

//Maintenance Components
import { CompanyTypesComponent } from './maintenance/company-types/company-types.component';
import { CompanyTypeEditComponent } from './maintenance/company-types/comapny-type-edit.component';
import { AddressTypesComponent } from './maintenance/address-types/address-types.component';
import { AddressTypeEditComponent } from './maintenance/address-types/address-type-edit.component';
import { AudioVisualItemsComponent } from './maintenance/audio-visual-items/audio-visual-items.component';
import { AudioVisualItemEditComponent } from './maintenance/audio-visual-items/audio-visual-item-edit.component';
import { BroadcastLettersComponent } from './maintenance/broadcast-letters/broadcast-letters.component';
import { BroadcastLetterEditComponent } from './maintenance/broadcast-letters/broadcast-letter-edit.component';
import { ChargeTypesComponent } from './maintenance/charge-types/charge-types.component';
import { ChargeTypeEditComponent } from './maintenance/charge-types/charge-type-edit.component';
import { CreditTypesComponent } from './maintenance/credit-types/credit-types.component';
import { CreditTypeEditComponent } from './maintenance/credit-types/credit-type-edit.component';
import { ContactTypesComponent } from './maintenance/contact-types/contact-types.component';
import { ContactTypeEditComponent } from './maintenance/contact-types/contact-type-edit.component';
import { DataMaintenanceComponent } from './maintenance/data-maintenance/data-maintenance.component';
import { DefaultLetterSetupEditComponent } from './maintenance/defult-letter-setup/default-letter-setup-edit.component';
import { DepartmentsComponent } from './maintenance/departments/departments.component';
import { DepartmentEditComponent } from './maintenance/departments/department-edit.component';
import { EmailTypeEditComponent } from './maintenance/email-types/email-type-edit.component';
import { EmailTypesComponent } from './maintenance/email-types/email-types.component';
import { FoodAndBeverageComponent } from './maintenance/food-and-beverage/food-and-beverage.component';
import { FoodAndBeverageEditComponent } from './maintenance/food-and-beverage/food-and-beverage-edit.component';
import { GuestTypesComponent } from './maintenance/guest-types/guest-types.component';
import { GuestTypeEditComponent } from './maintenance/guest-types/guest-type-edit.component';
import { MailingListsComponent } from './maintenance/mailing-lists/mailing-lists.component';
import { MailingListEditComponent } from './maintenance/mailing-lists/mailing-list-edit.component';
import { PaymentMethodsComponent } from './maintenance/payment-methods/payment-methods.component';
import { PaymentMethodEditComponent } from './maintenance/payment-methods/payment-method-edit.component';
import { PaymentTypesComponent } from './maintenance/payment-types/payment-types.component';
import { PaymentTypeEditComponent } from './maintenance/payment-types/payment-type-edit.component';
import { PeopleTypesComponent } from './maintenance/people-types/people-types.component';
import { PersonTypeEditComponent } from './maintenance/people-types/person-type-edit.component';
import { RoomSetupTypesComponent } from './maintenance/room-setup-types/room-setup-types.component';
import { RoomSetupTypeEditComponent } from './maintenance/room-setup-types/room-setup-type-edit.component';
import { SetupItemsComponent } from './maintenance/setup-items/setup-items.component';
import { SetupItemEditComponent } from './maintenance/setup-items/setup-item-edit.component';
import { SourceTypesComponent } from './maintenance/source-types/source-types.component';
import { SourceTypeEditComponent } from './maintenance/source-types/source-type-edit.component';
import { SpeakerTypesComponent } from './maintenance/speaker-types/speaker-types.component';
import { SpeakerTypeEditComponent } from './maintenance/speaker-types/speaker-type-edit.component';
import { StatesComponent } from './maintenance/states/states.component';
import { StateEditComponent } from './maintenance/states/state-edit.component';
import { TaskTemplateComponent } from './maintenance/task-template/task-template.component';
import { TaskTemplateEditComponent } from './maintenance/task-template/task-template-edit.component';
import { UserFieldSetupComponent } from './maintenance/user-field-setup/user-field-setup.component';
import { UserFieldSetupEditComponent } from './maintenance/user-field-setup/user-field-setup-edit.component';
import { VendorTypesComponent } from './maintenance/vendor-types/vendor-types.component';
import { VendorTypeEditComponent } from './maintenance/vendor-types/vendor-type-edit.component';
import { BaseFormComponent } from './base.form.component';
import { from } from 'rxjs';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
   declarations: [
    AppComponent,
    BaseFormComponent,
    HomeComponent,

    /*menu components*/
    NavMenuComponent,
    MaintenanceSideNavigation,

    CompaniesComponent,
    CompanyEditComponent,
    CompanyAddressesComponent,
    CompanyAddressEditComponent,
    CompanyEmailComponent,
    CompanyEmailEditComponent,
    CompanyNoteComponent,
    CompanyNoteEditComponent,
    CompanyPeopleComponent,
    CompanyExhibitorsComponent,

    PeopleComponent,
    PersonEditComponent,
    PersonAddressesComponent,
    PersonAddressEditComponent,
    PersonCompanyAddressComponent,

    MeetingsComponent,
    MeetingEditComponent,
    SessionsComponent,
    SessionEditComponent,
    SpeakersComponent,
    SpeakerEditComponent,
    ExhibitorsComponent,
    ExhibitorEditComponent,
    ExhibitorNoteComponent,
    ExhibitorNoteEditComponent,
    MaintenanceComponent,
    ReportsComponent,

    /*maintenance screens components*/
    CompanyTypesComponent,
    CompanyTypeEditComponent,
    AddressTypesComponent,
    AddressTypeEditComponent,
    AudioVisualItemsComponent,
    AudioVisualItemEditComponent,
    BroadcastLettersComponent,
    BroadcastLetterEditComponent,   /*not sure that this is needed, will need to figure out how broadcast letters is going to work*/
    ChargeTypesComponent,
    ChargeTypeEditComponent,
    CreditTypesComponent,
    CreditTypeEditComponent,
    ContactTypesComponent,
    ContactTypeEditComponent,
    DataMaintenanceComponent,
    DefaultLetterSetupEditComponent,
    DepartmentsComponent,
    DepartmentEditComponent,
    EmailTypesComponent,
    EmailTypeEditComponent,
    FoodAndBeverageComponent,
    FoodAndBeverageEditComponent,
    GuestTypesComponent,
    GuestTypeEditComponent,
    MailingListsComponent,
    MailingListEditComponent,
    PaymentMethodsComponent,
    PaymentMethodEditComponent,
    PaymentTypesComponent,
    PaymentTypeEditComponent,
    PeopleTypesComponent,
    PersonTypeEditComponent,
    RoomSetupTypesComponent,
    RoomSetupTypeEditComponent,
    SetupItemsComponent,
    SetupItemEditComponent,
    SourceTypesComponent,
    SourceTypeEditComponent,
    SpeakerTypesComponent,
    SpeakerTypeEditComponent,
    StatesComponent,
    StateEditComponent,
    TaskTemplateComponent,
    TaskTemplateEditComponent,
    UserFieldSetupComponent,
    UserFieldSetupEditComponent,
    VendorTypesComponent,
    VendorTypeEditComponent
    /*end maintenance screens components*/
   ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      //{ path: '', component: MeetingsComponent, pathMatch: 'full'},


      { path: 'companies', component: CompaniesComponent },
      { path: 'company', component: CompanyEditComponent },
      { path: 'company/:companyId', component: CompanyEditComponent },
      { path: 'companyAddresses', component: CompanyAddressesComponent },
      { path: 'companyAddress/:companyId', component: CompanyAddressEditComponent },
      { path: 'companyAddress/:companyId/:addressId', component: CompanyAddressEditComponent },
      { path: 'companyEmails', component: CompanyEmailComponent },
      { path: 'companyEmail/:companyId', component: CompanyEmailEditComponent },
      { path: 'companyEmail/:companyId/:emailId', component: CompanyEmailEditComponent },
      { path: 'companyNotes', component: CompanyNoteComponent },
      { path: 'companyNote/:companyId', component: CompanyNoteEditComponent },
      { path: 'companyNote/:companyId/:noteId', component: CompanyNoteEditComponent },
      { path: 'companyPeople', component: CompanyPeopleComponent },
      { path: 'companyExhibitors', component: CompanyExhibitorsComponent },

      { path: 'people', component: PeopleComponent },
      { path: 'person', component: PersonEditComponent },
      { path: 'person/:personId', component: PersonEditComponent },
      { path: 'personAddress/:addressId/:personId', component: PersonAddressEditComponent },
      { path: 'personAddress/:personId', component: PersonAddressEditComponent },
      { path: 'personCompanyAddress/:personId/:companyId', component: PersonCompanyAddressComponent },

      { path: 'meetings', component: MeetingsComponent },
      { path: 'meeting', component: MeetingEditComponent },
      { path: 'meeting/:id', component: MeetingEditComponent },

      { path: 'sessions', component: SessionsComponent },           //might need to add a secondary id to this?
      { path: 'session', component: SessionEditComponent },         //might need to add a secondary id to this?
      { path: 'session/:id', component: SessionEditComponent },     //might need to add a secondary id to this?

      { path: 'speakers', component: SpeakersComponent },           
      { path: 'speaker', component: SpeakerEditComponent },         
      { path: 'speaker/:id', component: SpeakerEditComponent },      //change this to have personId, meetingCode, and sessionCode

      { path: 'exhibitors', component: ExhibitorsComponent },       
      { path: 'exhibitor', component: ExhibitorEditComponent },     
      { path: 'exhibitor/:companyId/:meetingCode/:exhibitorId', component: ExhibitorEditComponent },
      { path: 'exhibitorNotes', component: ExhibitorNoteComponent },
      { path: 'exhibitorNote/:exhibitorId/:companyId/:meetingCode', component: ExhibitorNoteEditComponent },
      { path: 'exhibitorNote/:exhibitorId/:noteId/:companyId/:meetingCode', component: ExhibitorNoteEditComponent },

      { path: 'reports', component: ReportsComponent },

      /*Maintenance screens components*/
      { path: 'maintenance', component: MaintenanceComponent},
      { path: 'companyTypes', component: CompanyTypesComponent },
      { path: 'companyType', component: CompanyTypeEditComponent },
      { path: 'companyType/:companyTypeId', component: CompanyTypeEditComponent },
      { path: 'addressTypes', component: AddressTypesComponent },
      { path: 'addressType', component: AddressTypeEditComponent },
      { path: 'addressType/:addressTypeId', component: AddressTypeEditComponent },
      { path: 'AudioVisualItems', component: AudioVisualItemsComponent },
      { path: 'AudioVisualItem', component: AudioVisualItemEditComponent },
      { path: 'AudioVisualItem/:avId', component: AudioVisualItemEditComponent },
      { path: 'chargeTypes', component: ChargeTypesComponent },
      { path: 'ChargeType', component: ChargeTypeEditComponent },
      { path: 'ChargeType/:chargeTypeId', component: ChargeTypeEditComponent },
      { path: 'contactTypes', component: ContactTypesComponent },
      { path: 'contactType', component: ContactTypeEditComponent },
      { path: 'contactType/:contactTypeId', component: ContactTypeEditComponent },
      { path: 'creditTypes', component: CreditTypesComponent },
      { path: 'creditType', component: CreditTypeEditComponent },
      { path: 'creditType/:creditTypeCode', component: CreditTypeEditComponent },
      { path: 'emailTypes', component: EmailTypesComponent },
      { path: 'emailType', component: EmailTypeEditComponent },
      { path: 'emailType/:emailTypeId', component: EmailTypeEditComponent },
      { path: 'fbItems', component: FoodAndBeverageComponent },
      { path: 'fbItem', component: FoodAndBeverageEditComponent },
      { path: 'fbItem/:fbId', component: FoodAndBeverageEditComponent },
      { path: 'guestTypes', component: GuestTypesComponent },
      { path: 'guestType', component: GuestTypeEditComponent },
      { path: 'guestType/:guestTypeId', component: GuestTypeEditComponent },
      { path: 'mailingLists', component: MailingListsComponent },
      { path: 'mailingList', component: MailingListEditComponent },
      { path: 'mailingList/:listCode', component: MailingListEditComponent },
      { path: 'paymentMethods', component: PaymentMethodsComponent },
      { path: 'paymentMethod', component: PaymentMethodEditComponent },
      { path: 'paymentMethod/:paymentMethodId', component: PaymentMethodEditComponent },
      { path: 'paymentTypes', component: PaymentTypesComponent },
      { path: 'paymentType', component: PaymentTypeEditComponent },
      { path: 'paymentType/:paymentTypeId', component: PaymentTypeEditComponent },
      { path: 'peopleTypes', component: PeopleTypesComponent },
      { path: 'peopleType', component: PersonTypeEditComponent },
      { path: 'peopleType/:peopleTypeId', component: PersonTypeEditComponent },
      { path: 'roomSetups', component: RoomSetupTypesComponent },
      { path: 'roomSetup', component: RoomSetupTypeEditComponent },
      { path: 'roomSetup/:setupId', component: RoomSetupTypeEditComponent },
      { path: 'sources', component: SourceTypesComponent },
      { path: 'source', component: SourceTypeEditComponent },
      { path: 'source/:sourceId', component: SourceTypeEditComponent },
      { path: 'speakerTypes', component: SpeakerTypesComponent },
      { path: 'speakerType', component: SpeakerTypeEditComponent },
      { path: 'speakerType/:speakerTypeId', component: SpeakerTypeEditComponent },
      { path: 'vendorTypes', component: VendorTypesComponent },
      { path: 'vendorType', component: VendorTypeEditComponent },
      { path: 'vendorType/:vendorTypeId', component: VendorTypeEditComponent },
      { path: 'setupItems', component: SetupItemsComponent },
      { path: 'setupItem', component: SetupItemEditComponent },
      { path: 'setupItem/:setupId', component: SetupItemEditComponent },
      { path: 'states', component: StatesComponent },
      { path: 'state/:stateCode', component: StateEditComponent },
      { path: 'state', component: StateEditComponent },
      { path: 'taskTemplates', component: TaskTemplateComponent },
      { path: 'taskTemplate/:taskTemplateId', component: TaskTemplateEditComponent },
      { path: 'taskTemplate', component: TaskTemplateEditComponent }
      /*end maintenance screens*/


    ]),
    BrowserAnimationsModule,
    AngularMaterialModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    [NgbModule]
   ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
