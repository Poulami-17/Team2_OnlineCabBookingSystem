import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagecustomersComponent } from './managecustomers.component';

describe('ManagecustomersComponent', () => {
  let component: ManagecustomersComponent;
  let fixture: ComponentFixture<ManagecustomersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagecustomersComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagecustomersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
