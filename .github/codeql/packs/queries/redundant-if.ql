/**
 * @id cs/demo/redundant-if
 * @name Redundant if
 * @description Checks for redundant if
 * @tags if
 *       condition
 * @kind problem
 */

import csharp

from IfStmt ifstmt, BlockStmt block
where ifstmt.getThen() = block and block.isEmpty()
select ifstmt, "This 'if' statement is redundant."