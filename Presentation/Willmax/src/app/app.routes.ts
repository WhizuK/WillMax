import { Routes } from '@angular/router';
import { ApartmentListingComponent } from './components/apartment-listing/apartment-listing/apartment-listing.component';
import { ApartmentViewComponent } from './components/apartment-view/apartment-view/apartment-view.component';
import { ApartmentCreateComponent } from './components/apartment-create/apartment-create/apartment-create.component';
import { UserListingComponent } from './components/user-listing/user-listing/user-listing.component';
import { LoginComponent } from './components/login/login/login.component';

export const routes: Routes = [
    { path: 'apartment-listing', component: ApartmentListingComponent },
    { path: 'apartment-view/:id', component: ApartmentViewComponent },
    { path: 'apartment-create', component: ApartmentCreateComponent },
    { path: 'user-listing', component: UserListingComponent },
    { path: 'app-login', component: LoginComponent },
];
