// Innovace Intech Solution Pvt Ltd
import React, { useMemo } from "react";

import type { UIElement } from "../../constants/types";
import { useGridStore } from "../../store/useGridStore";

const PAGE_SIZE_OPTIONS = [
  "5",
  "10",
  "25",
  "50",
  "100",
  "200",
  "300",
  "500",
  "1000",
];

const RepeaterGridFooter: React.FC<{ element: UIElement }> = ({ element }) => {
  const parentElementId = element["ParentElementId"];
  const pagination = useGridStore(
    (store) => store.pagination?.[String(parentElementId)]
  );
  const setPageSize = useGridStore((store) => store.setPageSize);
  const setCurrentPage = useGridStore((store) => store.setCurrentPage);
  const nextPage = useGridStore((store) => store.nextPage);
  const prevPage = useGridStore((store) => store.prevPage);
  const firstPage = useGridStore((store) => store.firstPage);
  const lastPage = useGridStore((store) => store.lastPage);

  const start = useMemo(() => {
    const tempStart = (pagination?.currentPage - 1) * pagination?.pageSize + 1;
    return isNaN(tempStart) ? 0 : tempStart;
  }, [pagination]);

  const end = useMemo(() => {
    const tempEnd = Math.min(
      pagination?.currentPage * pagination?.pageSize,
      pagination?.totalItems || 0
    );
    return isNaN(tempEnd) ? 0 : tempEnd;
  }, [pagination]);

  const totalPages = useMemo(() => {
    if (!pagination?.pageSize || !pagination?.totalItems) {
      return 1;
    }

    return Math.max(
      1,
      Math.ceil(pagination.totalItems / pagination.pageSize)
    );
  }, [pagination]);

  const handlePageSizeChange = (
    event: React.ChangeEvent<HTMLSelectElement>
  ): void => {
    if (!parentElementId) {
      return;
    }

    setPageSize(parentElementId, Number(event.target.value));
  };

  const handlePageInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ): void => {
    if (!parentElementId) {
      return;
    }

    const next = Number(event.target.value);
    if (Number.isNaN(next) || next < 1) {
      return;
    }

    setCurrentPage(parentElementId, next);
  };

  const handleFirst = (): void => {
    if (parentElementId) {
      firstPage(parentElementId);
    }
  };

  const handlePrev = (): void => {
    if (parentElementId) {
      prevPage(parentElementId);
    }
  };

  const handleNext = (): void => {
    if (parentElementId) {
      nextPage(parentElementId);
    }
  };

  const handleLast = (): void => {
    if (parentElementId) {
      lastPage(parentElementId);
    }
  };

  const renderPaginationNumbers = (): React.ReactNode[] => {
    const currentPage = pagination?.currentPage || 1;
    const pages: React.ReactNode[] = [];

    const createPageItem = (page: number, label?: React.ReactNode) => (
      <li
        key={`page-${page}-${label ?? page}`}
        className={`page-item ${currentPage === page ? "active" : ""}`}
      >
        <button
          type="button"
          className="page-link"
          onClick={() => parentElementId && setCurrentPage(parentElementId, page)}
        >
          {label ?? page}
        </button>
      </li>
    );

    if (totalPages <= 7) {
      for (let page = 1; page <= totalPages; page += 1) {
        pages.push(createPageItem(page));
      }
      return pages;
    }

    pages.push(createPageItem(1));

    if (currentPage > 4) {
      pages.push(
        <li key="start-ellipsis" className="page-item disabled">
          <span className="page-link">…</span>
        </li>
      );
    }

    const startPage = Math.max(2, currentPage - 1);
    const endPage = Math.min(totalPages - 1, currentPage + 1);
    for (let page = startPage; page <= endPage; page += 1) {
      pages.push(createPageItem(page));
    }

    if (currentPage < totalPages - 3) {
      pages.push(
        <li key="end-ellipsis" className="page-item disabled">
          <span className="page-link">…</span>
        </li>
      );
    }

    pages.push(createPageItem(totalPages));

    return pages;
  };

  return (
    <div className={`datatable-footer border-top py-2 px-3 d-flex justify-content-between align-items-center flex-wrap gap-2 ${element?.Css}`}>
      <div className="d-flex align-items-center gap-2">
        <label className="mb-0 text-muted" htmlFor={`${parentElementId}-page-size`}>
          Show
        </label>
        <select
          id={`${parentElementId}-page-size`}
          className="form-select form-select-sm w-auto"
          value={String(pagination?.pageSize || PAGE_SIZE_OPTIONS[0])}
          onChange={handlePageSizeChange}
        >
          {PAGE_SIZE_OPTIONS.map((count) => (
            <option key={count} value={count}>
              {count}
            </option>
          ))}
        </select>
      </div>

       <div className="d-flex align-items-center gap-2">
        <button
          type="button"
          className="btn btn-link btn-sm px-2"
          aria-label="First page"
          onClick={handleFirst}
        >
          «
        </button>
        <button
          type="button"
          className="btn btn-link btn-sm px-2"
          aria-label="Previous page"
          onClick={handlePrev}
        >
          ‹
        </button>
        <input
          type="number"
          min={1}
          max={totalPages}
          className="form-control form-control-sm text-center"
          style={{ width: "60px" }}
          value={String(pagination?.currentPage || 1)}
          onChange={handlePageInputChange}
        />
        <span className="text-muted small">
          of {totalPages}
        </span>
        <button
          type="button"
          className="btn btn-link btn-sm px-2"
          aria-label="Next page"
          onClick={handleNext}
        >
          ›
        </button>
        <button
          type="button"
          className="btn btn-link btn-sm px-2"
          aria-label="Last page"
          onClick={handleLast}
        >
          »
        </button>
      </div> 

      <div className="text-muted d-flex align-items-center gap-3 flex-wrap">
        <ul className="pagination pagination-sm mb-0">
          <li className={`page-item ${pagination?.currentPage === 1 ? "disabled" : ""}`}>
            <button
              className="page-link"
              type="button"
              onClick={handlePrev}
              aria-label="Previous page"
            >
              ‹
            </button>
          </li>
          {renderPaginationNumbers()}
          <li
            className={`page-item ${
              pagination?.currentPage === totalPages ? "disabled" : ""
            }`}
          >
            <button
              className="page-link"
              type="button"
              onClick={handleNext}
              aria-label="Next page"
            >
              ›
            </button>
          </li>
        </ul>
        <span>
          View {start}–{end} of {pagination?.totalItems || 0} List
        </span>
      </div>
    </div>
  );
};

export default RepeaterGridFooter;
