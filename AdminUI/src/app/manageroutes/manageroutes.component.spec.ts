import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageroutesComponent } from './manageroutes.component';

describe('ManageroutesComponent', () => {
  let component: ManageroutesComponent;
  let fixture: ComponentFixture<ManageroutesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManageroutesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManageroutesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
