import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagedriversComponent } from './managedrivers.component';

describe('ManagedriversComponent', () => {
  let component: ManagedriversComponent;
  let fixture: ComponentFixture<ManagedriversComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagedriversComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagedriversComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
