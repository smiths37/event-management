import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { faMapMarkedAlt, faPhotoVideo, faEnvelopeOpenText, faFileInvoiceDollar, faBuilding, faAddressCard, faAward, faDatabase, faMailBulk, faSitemap, faInbox, faUtensils, faUserPlus, faAddressBook, faDollarSign, faFileInvoice, faUser, faChair, faPeopleCarry, faSearchLocation, faChalkboardTeacher, faFlagUsa, faListOl, faUsersCog, faStore } from '@fortawesome/free-solid-svg-icons';
import { MaintenanceSideNavigation } from '../maintenance-nav-menu/maintenance-nav-menu.component';

@Component({
  selector: 'app-maintenance',
  templateUrl: './maintenance.component.html',
  styleUrls: ['./maintenance.component.css']
})

export class MaintenanceComponent {
  constructor(
    //private companyService: CompanyService)
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {
  }

  //font awesome icons
  faMapMarkedAlt = faMapMarkedAlt;
  faPhotoVideo = faPhotoVideo;
  faEnvelopeOpenText = faEnvelopeOpenText;
  faFileInvoiceDollar = faFileInvoiceDollar;
  faBuilding = faBuilding;
  faAddressCard = faAddressCard;
  faAward = faAward;
  faDatabase = faDatabase;
  faMailBulk = faMailBulk;
  faSitemap = faSitemap;
  faInbox = faInbox;
  faUtensils = faUtensils;
  faUserPlus = faUserPlus;
  faAddressBook = faAddressBook;
  faDollarSign = faDollarSign;
  faFileInvoice = faFileInvoice;
  faUser = faUser;
  faChair = faChair;
  faPeopleCarry = faPeopleCarry;
  faSearchLocation = faSearchLocation;
  faChalkboardTeacher = faChalkboardTeacher;
  faFlagUsa = faFlagUsa;
  faListOl = faListOl;
  faUsersCog = faUsersCog;
  faStore = faStore;

}
