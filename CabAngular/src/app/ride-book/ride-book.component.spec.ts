import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RideBookComponent } from './ride-book.component';

describe('RideBookComponent', () => {
  let component: RideBookComponent;
  let fixture: ComponentFixture<RideBookComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RideBookComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RideBookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
