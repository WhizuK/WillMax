import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApartmentListingComponent } from './apartment-listing.component';

describe('ApartmentListingComponent', () => {
  let component: ApartmentListingComponent;
  let fixture: ComponentFixture<ApartmentListingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ApartmentListingComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApartmentListingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
