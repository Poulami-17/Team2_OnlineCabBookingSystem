import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WaitForRideComponent } from './wait-for-ride.component';

describe('WaitForRideComponent', () => {
  let component: WaitForRideComponent;
  let fixture: ComponentFixture<WaitForRideComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WaitForRideComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(WaitForRideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
